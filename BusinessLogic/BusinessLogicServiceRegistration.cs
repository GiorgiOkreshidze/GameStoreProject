using System.Reflection;
using BusinessLogic.Contracts;
using BusinessLogic.Services;
using BusinessLogic.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic;

public static class BusinessLogicServiceRegistration
{
    public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<IGameService, GameService>();
        services.AddScoped<IPlatformService, PlatformService>();
        services.AddScoped<IGenreService, GenreService>();
        services.AddScoped<IPublisherService, PublisherService>();
        services.AddScoped<IValidationsHandler, ValidationsHandler>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ICommentService, CommentService>();

        return services;
    }
}