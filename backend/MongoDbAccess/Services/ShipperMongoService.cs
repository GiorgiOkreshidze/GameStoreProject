using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class ShipperMongoService : IShipperMongoService
{
    private readonly IMongoCollection<BsonDocument> _shippersCollection;

    public ShipperMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _shippersCollection = mongoDatabase.GetCollection<BsonDocument>(dbSettings.Value.ShippersCollectionName);
    }

    public ICollection<BsonDocument> GetAllShippersMongo()
    {
        return _shippersCollection.Find(_ => true).ToList();
    }
}