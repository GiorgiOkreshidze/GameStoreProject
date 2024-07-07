using BusinessLogic;
using DataAccess;
using Gamestore;
using Gamestore.Middlewares.Exception;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBusinessLogicServices();
builder.Services.AddDatabaseServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CustomMiddleware>();

builder.Services.AddExceptionHandler<ExceptionHandler>();

builder.Services.AddMemoryCache();

var exposeHeadersPolicy = "ExposeHeadersPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(exposeHeadersPolicy,
        policy =>
        {
            policy.AllowAnyOrigin()
                .WithExposedHeaders("x-total-numbers-of-games");
        });
});


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(exposeHeadersPolicy);

app.UseExceptionHandler(_ => { });

app.UseAuthorization();

app.MapControllers();

app.UseCustomMiddleware();

app.Run();