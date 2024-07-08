using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DatabaseServiceRegistration
{
    public static IServiceCollection AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connString = configuration.GetConnectionString("GamestoreDbConnection");
        
        services.AddDbContext<GameDbContext>(options => options.UseSqlServer(connString));
        services.AddScoped<IGameDbService, GameDbService>();
        services.AddScoped<IPlatformDbService, PlatformDbService>();
        services.AddScoped<IGenreDbService, GenreDbService>();
        services.AddScoped<IPublisherDbService, PublisherDbService>();

        return services;
    }
}