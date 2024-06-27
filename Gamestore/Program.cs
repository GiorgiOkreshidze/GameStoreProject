using BusinessLogic;
using DataAccess;
using Gamestore;
using Gamestore.Middlewares.Exception;

var builder = WebApplication.CreateBuilder(args);

/*
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IPlatformService, PlatformService>();
builder.Services.AddScoped<IGenreService, GenreService>();
*/

builder.Services.AddBusinessLogicServices();
builder.Services.AddDatabaseServices(builder.Configuration);

/*
builder.Services.AddScoped<IGameDbService, GameDbService>();
builder.Services.AddScoped<IPlatformDbService, PlatformDbService>();
builder.Services.AddScoped<IGenreDbService, GenreDbService>();
*/

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CustomMiddleware>();

builder.Services.AddExceptionHandler<ExceptionHandler>();

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseExceptionHandler(_ => { });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCustomMiddleware();

/*app.Use(async Task (context, next) =>
{
    context.Response.OnStarting(state => {
        var httpContext = (HttpContext)state;

        
        var gameDbService = context.RequestServices.GetService<IGameDbService>();
        string gamesCount = gameDbService.GetGamesNumber().ToString();
        httpContext.Response.Headers.Add("x-total-numbers-of-games",gamesCount);
        
        return Task.CompletedTask;
    }, context);

    await next(context);
});*/

app.Run();