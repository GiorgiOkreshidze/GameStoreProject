using BusinessLogic;
using DataAccess;
using Gamestore.Middlewares.Exception;
using Gamestore.Middlewares.Logging;
using Gamestore.Middlewares.Other;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBusinessLogicServices();
builder.Services.AddDatabaseServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GamesCountMiddleware>();

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

Log.Logger = new LoggerConfiguration()
            .WriteTo.Logger(lc => lc
                .Filter.ByExcluding(e => e.Level == Serilog.Events.LogEventLevel.Error || e.Level == Serilog.Events.LogEventLevel.Fatal
                    || e.Level == Serilog.Events.LogEventLevel.Warning)
                .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day))
            .WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(e => e.Level == Serilog.Events.LogEventLevel.Error || e.Level == Serilog.Events.LogEventLevel.Fatal
                    || e.Level == Serilog.Events.LogEventLevel.Warning)
                .WriteTo.File("logs/exceptions-.txt", rollingInterval: RollingInterval.Day))
            .CreateLogger();



var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(exposeHeadersPolicy);

app.UseMiddleware<RequestLoggingMiddleware>();

app.UseExceptionHandler(_ => { });

app.UseAuthorization();

app.MapControllers();

app.UseGamesCountMiddleware();

app.Run();