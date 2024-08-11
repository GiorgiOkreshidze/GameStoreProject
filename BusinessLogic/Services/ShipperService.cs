using BusinessLogic.Contracts;
using MongoDB.Bson;
using MongoDbAccess.Contracts;

namespace BusinessLogic.Services;

public class ShipperService(IShipperMongoService shipperMongoService) : IShipperService
{
    public ICollection<object> GetShippers()
    {
        var shippers = shipperMongoService.GetAllShippersMongo();
        return shippers.Select(BsonTypeMapper.MapToDotNetValue).ToList();
    }
}