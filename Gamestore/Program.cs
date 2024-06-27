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

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(_ => { });

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCustomMiddleware();

app.Run();