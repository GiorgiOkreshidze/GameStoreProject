using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.LoggingDecorators;
using DataAccess.Services;
using DataAccess.StoreIntegrationContracts;
using DataAccess.StoreIntegrationServices;
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
        services.AddScoped<IPlatformDbService, PlatformDbService>();
        services.AddScoped<IDatabasesSyncDbService, DatabasesSyncDbService>();
        services.AddScoped<IUserDbService, UserDbService>();
        services.AddScoped<IRoleDbService, RoleDbService>();

        services.AddScoped<IGameDbService, GameDbService>();
        services.AddScoped<IOrderDbService, OrderDbService>();
        services.AddScoped<IPublisherDbService, PublisherDbService>();
        services.AddScoped<IGenreDbService, GenreDbService>();
        services.AddScoped<ICommentDbService, CommentDbService>();

        services.AddScoped<IGenreServiceDecorator, GenreServiceDecorator>();
        services.AddScoped<IPublisherServiceDecorator, PublisherServiceDecorator>();
        services.AddScoped<IGameServiceDecorator, GameServiceDecorator>();

        // Mongo Db integration decorators
        services.Decorate<IGameDbService, GameServiceDecorator>();
        services.Decorate<IOrderDbService, OrderDecorator>();
        services.Decorate<IPublisherDbService, PublisherServiceDecorator>();
        services.Decorate<IGenreDbService, GenreServiceDecorator>();
        services.Decorate<ICommentDbService, CommentServiceDecorator>();

        // Logging Decorators
        services.Decorate<IGameDbService, GameDbServiceLoggingDecorator>();
        services.Decorate<IOrderDbService, OrderDbServiceLoggingDecorator>();
        services.Decorate<IPublisherDbService, PublisherDbServiceLoggingDecorator>();
        services.Decorate<IGenreDbService, GenreDbServiceLoggingDecorator>();
        services.Decorate<ICommentDbService, CommentDbServiceLoggingDecorator>();
        services.Decorate<IPlatformDbService, PlatformDbServiceLoggingDecorator>();

        return services;
    }
}