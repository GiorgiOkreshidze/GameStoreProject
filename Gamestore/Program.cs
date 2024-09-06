#pragma warning disable IDE0005
using BusinessLogic;
using DataAccess;
using DTOs.CustomConvertor;
using MongoDbAccess;
#pragma warning restore IDE0005
using System.Text;
using DataAccess.Contracts;
using Gamestore.Middlewares.Exception;
using Gamestore.Middlewares.Logging;
using Gamestore.Middlewares.Other;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

builder.Services.AddMvc();

builder.Services.AddBusinessLogicServices();
builder.Services.AddDatabaseServices(builder.Configuration);
builder.Services.AddMongoDbServices(builder.Configuration);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new NullableGuidConverter());
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme()
    {
        Description = "Authorization header using bearer scheme(\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
    });
    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey =
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:Key").Value!)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };
    });
builder.Services.AddAuthorization(options =>
{
    var policies = new Dictionary<string, string[]>
    {
        { "RequireGetAllUsersPermission", ["GetAllUsers"] },
        { "RequireGetUserByIdPermission", ["GetUserById"] },
        { "RequireDeleteUserByIdPermission", ["DeleteUserById"] },
        { "RequireAddUserPermission", ["AddUser"] },
        { "RequireUpdateUserPermission", ["UpdateUser"] },
        { "RequireGetRolesOfUserPermission", ["GetRolesOfUser"] },
        { "RequireGetShippersPermission", ["GetShippers"] },
        { "RequireGetAllRolesPermission", ["GetAllRoles"] },
        { "RequireGetRoleByIdPermission", ["GetRoleById"] },
        { "RequireDeleteRoleByIdPermission", ["DeleteRoleById"] },
        { "RequireGetAllPermissionsPermission", ["GetAllPermissions"] },
        { "RequireGetPermissionsByRoleIdPermission", ["GetPermissionsByRoleId"] },
        { "RequireAddRolePermission", ["AddRole"] },
        { "RequireUpdateRolePermission", ["UpdateRole"] },
        { "RequireCreatePublisherPermission", ["CreatePublisher"] },
        { "RequireGetPublisherByCompanyNamePermission", ["GetPublisherByCompanyName"] },
        { "RequireGetAllPublishersPermission", ["GetAllPublishers"] },
        { "RequireUpdatePublisherPermission", ["UpdatePublisher"] },
        { "RequireDeletePublisherPermission", ["DeletePublisher"] },
        { "RequireGetGamesByPublisherNamePermission", ["GetGamesByPublisherName"] },
        { "RequireCreatePlatformPermission", ["CreatePlatform"] },
        { "RequireGetAllPlatformsPermission", ["GetAllPlatforms"] },
        { "RequireUpdatePlatformPermission", ["UpdatePlatform"] },
        { "RequireDeletePlatformPermission", ["DeletePlatform"] },
        { "RequireGetPlatformByIdPermission", ["GetPlatformById"] },
        { "RequireGetGamesByPlatformIdPermission", ["GetGamesByPlatformId"] },
        { "RequireGetAllOrdersPermission", ["GetAllOrders"] },
        { "RequireGetOrderByIdPermission", ["GetOrderById"] },
        { "RequireGetAllOrdersDetailsPermission", ["GetAllOrdersDetails"] },
        { "RequireDeleteGameFromCartPermission", ["DeleteGameFromCart"] },
        { "RequireGetCartPermission", ["GetCart"] },
        { "RequireGetPaymentMethodsPermission", ["GetPaymentMethods"] },
        { "RequirePaymentPermission", ["Payment"] },
        { "RequireUpdateOrderDetailQuantityPermission", ["UpdateOrderDetailQuantity"] },
        { "RequireDeleteOrderDetailsPermission", ["DeleteOrderDetails"] },
        { "RequireShipOrderPermission", ["ShipOrder"] },
        { "RequireAddGameToOrderByKeyPermission", ["AddGameToOrderByKey"] },
        { "RequireGetDateFilterOptionsPermission", ["GetDateFilterOptions"] },
        { "RequireCreateGenrePermission", ["CreateGenre"] },
        { "RequireGetAllGenresPermission", ["GetAllGenres"] },
        { "RequireUpdateGenrePermission", ["UpdateGenre"] },
        { "RequireDeleteGenrePermission", ["DeleteGenre"] },
        { "RequireGetGenrePermission", ["GetGenre"] },
        { "RequireGetGamesByGenreIdPermission", ["GetGamesByGerneId"] },
        { "RequireGetSubGenresPermission", ["GetSubGenres"] },
        { "RequireCreateGamePermission", ["CreateGame"] },
        { "RequireGetGamesPermission", ["GetGames"] },
        { "RequireUpdateGamePermission", ["UpdateGame"] },
        { "RequireDeleteGamePermission", ["DeleteGame"] },
        { "RequireGetGameByKeyPermission", ["GetGameByKey"] },
        { "RequireGetGameByIdPermission", ["GetGameById"] },
        { "RequireGetGenresOfGamePermission", ["GetGenresOfGame"] },
        { "RequireGetPlatformsOfGamePermission", ["GetPlatformsOfGame"] },
        { "RequireGetPublisherOfGamePermission", ["GetPublisherOfGame"] },
        { "RequireDownloadGameFilePermission", ["DownloadGameFile"] },
        { "RequireAddGameInCartPermission", ["AddGameInCart"] },
        { "RequireGetCommentsPermission", ["GetComments"] },
        { "RequireAddCommentPermission", ["AddComment"] },
        { "RequireDeleteCommentPermission", ["DeleteComment"] },
        { "RequireGetPaginationOptionsPermission", ["GetPaginationOptions"] },
        { "RequireGetSortingOptionsPermission", ["GetSortingOptions"] },
        { "RequireGetAllGamesPermission", ["GetAllGames"] },
        { "RequireGetBanDurationsPermission", ["GetBanDurations"] },
        { "RequireBanUserPermission", ["BanUser"] },
    };

    foreach (var policy in policies)
    {
        options.AddPolicy(policy.Key, policyBuilder =>
            policyBuilder.RequireClaim("Permission", policy.Value));
    }
});

builder.Services.AddScoped<GamesCountMiddleware>();

builder.Services.AddMemoryCache();

var exposeHeadersPolicy = "ExposeHeadersPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        exposeHeadersPolicy,
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithExposedHeaders("x-total-numbers-of-games");
        });
});

Log.Logger = new LoggerConfiguration()
            .WriteTo.Logger(lc => lc
                .Filter.ByExcluding(e => e.Level is Serilog.Events.LogEventLevel.Error or Serilog.Events.LogEventLevel.Fatal
                    or Serilog.Events.LogEventLevel.Warning)
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day))
            .WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(e => e.Level is Serilog.Events.LogEventLevel.Error or Serilog.Events.LogEventLevel.Fatal
                    or Serilog.Events.LogEventLevel.Warning)
                .WriteTo.File("logs/exceptions-.txt", rollingInterval: RollingInterval.Day))
            .CreateLogger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(exposeHeadersPolicy);

app.UseMiddleware<RequestLoggingMiddleware>();
app.UseMiddleware<ExceptionHandler>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseGamesCountMiddleware();

using (var scope = app.Services.CreateScope())
{
    var dataTransferService = scope.ServiceProvider.GetRequiredService<IDatabasesSyncDbService>();
    dataTransferService.PopulateIdSet();
}

app.Run();