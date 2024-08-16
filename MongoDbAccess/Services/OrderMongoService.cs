using System.Globalization;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class OrderMongoService : IOrderMongoService
{
    private readonly IMongoCollection<OrderDocument> _orderCollection;
    private readonly IMongoCollection<OrderDetailsDocument> _orderDetailsCollection;
    private readonly IMongoCollection<ProductDocument> _productCollection;

    public OrderMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _orderCollection = mongoDatabase.GetCollection<OrderDocument>(dbSettings.Value.OrdersCollectionName);
        _orderDetailsCollection =
            mongoDatabase.GetCollection<OrderDetailsDocument>(dbSettings.Value.OrderDetailsCollectionName);
        _productCollection = mongoDatabase.GetCollection<ProductDocument>(dbSettings.Value.ProductsCollectionName);
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

    public OrderDocument GetOrderById(string id)
    {
        return _orderCollection.Find(o => o.Id == id).FirstOrDefault();
    }

    public ICollection<OrderDetailsDocument> GetOrderDetailsByOrderId(int orderId)
    {
        return _orderDetailsCollection.Find(o => o.OrderID == orderId).ToList();
    }

    public ProductDocument GetProductByProductId(int productId)
    {
        return _productCollection.Find(p => p.ProductID == productId).FirstOrDefault();
    }

    public void ChangeProductUnitsInStock(string mongoId, int quantity)
    {
        var filter = Builders<ProductDocument>.Filter.Eq(p => p.Id, mongoId);

        var update = Builders<ProductDocument>.Update.Inc(p => p.UnitsInStock, -quantity);

        var result = _productCollection.UpdateOne(filter, update);

        if (result.ModifiedCount == 0)
        {
            throw new Exception("Product not found or update failed.");
        }
    }
}