using System.Globalization;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class OrderMongoService : IOrderMongoService
{
    private readonly IMongoCollection<OrderDocument> _orderCollection;

    public OrderMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _orderCollection = mongoDatabase.GetCollection<OrderDocument>(dbSettings.Value.OrdersCollectionName);
    }

    public ICollection<OrderDocument> GetAllMongo()
    {
        return _orderCollection.Find(_ => true).ToList();
    }

    public ICollection<OrderDocument> OrdersByIntervalMongo(DateTime start, DateTime end)
    {
        string startString = start.ToString("o", CultureInfo.InvariantCulture);
        string endString = end.ToString("o", CultureInfo.InvariantCulture);

        return _orderCollection.Find(o => o.OrderDateString.CompareTo(startString) >= 0
                                          && o.OrderDateString.CompareTo(endString) <= 0).ToList();
    }
}