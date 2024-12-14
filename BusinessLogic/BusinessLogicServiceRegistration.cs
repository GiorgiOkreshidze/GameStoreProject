using System.Reflection;
using BusinessLogic.Contracts;
using BusinessLogic.Responsibilities.AccessResponsibility;
using BusinessLogic.Responsibilities.AccessResponsibility.Comment;
using BusinessLogic.Responsibilities.AccessResponsibility.Game;
using BusinessLogic.Responsibilities.AccessResponsibility.General;
using BusinessLogic.Services;
using BusinessLogic.Strategies.CommentStrategies;
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
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ICommentService, CommentService>();
        services.AddScoped<IShipperService, ShipperService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IAccessService, AccessService>();

        services.AddHttpContextAccessor();

        services.AddScoped<ICommentStrategy, RegularCommentStrategy>();
        services.AddScoped<ICommentStrategy, QuoteCommentStrategy>();
        services.AddScoped<ICommentStrategy, ReplyCommentStrategy>();

        services.AddScoped<CommentValidator>();
        services.AddScoped<GameValidator>();
        services.AddScoped<GenreValidator>();
        services.AddScoped<PlatformValidation>();
        services.AddScoped<PublisherValidation>();

        services.AddScoped<IAccessHandler, GeneralPermissionAccessHandler>();
        services.AddScoped<IAccessHandler, DeleteGameAccessHandler>();
        services.AddScoped<IAccessHandler, UpdateGameAccessHandler>();
        services.AddScoped<IAccessHandler, BuyGameAccessHandler>();
        services.AddScoped<IAccessHandler, AddCommentAccessHandler>();
        services.AddScoped<IAccessHandler, DeleteCommentAccessHandler>();

        services.AddScoped<IDataSeederService, DataSeederService>();
        
        return services;
    }
}