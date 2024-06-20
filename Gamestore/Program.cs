using BusinessLogic.Services;
using DataAccess.DataContext;
using DataAccess.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("GamestoreDbConnection");
builder.Services.AddDbContext<GameDbContext>(options => options.UseSqlServer(connString));

builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGameDbService, GameDbService>();
builder.Services.AddScoped<IPlatformDbService, PlatformDbService>();
builder.Services.AddScoped<IGenreDbService, GenreDbService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.Use(async (context, next) =>
{
    var gameDbService = context.RequestServices.GetService<IGameDbService>();
    string gamesCount = gameDbService.getGamesNumber().ToString();
    context.Response.Headers.Add("x-total-numbers-of-games",gamesCount);
    await next(context);
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();