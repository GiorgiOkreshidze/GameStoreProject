using MongoDB.Bson;

namespace MongoDbAccess.Contracts;

public interface IShipperMongoService
{
    public ICollection<BsonDocument> GetAllShippersMongo();
}