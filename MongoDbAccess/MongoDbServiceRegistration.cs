using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
using MongoDbAccess.Services;

namespace MongoDbAccess;

public static class MongoDbServiceRegistration
{
    public static IServiceCollection AddMongoDbServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoDbSettings>(
            configuration.GetSection("MongoDb"));

        services.AddScoped<IProductMongoService, ProductMongoService>();
        services.AddScoped<ICategoryMongoService, CategoryMongoService>();
        services.AddScoped<IShipperMongoService, ShipperMongoService>();
        services.AddScoped<IOrderMongoService, OrderMongoService>();
        services.AddScoped<ISupplierMongoService, SupplierMongoService>();
        services.AddScoped<IChangeLogMongoService, ChangeLogMongoService>();

        return services;
    }
}