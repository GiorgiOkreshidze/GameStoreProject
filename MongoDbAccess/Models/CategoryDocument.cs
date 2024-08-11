using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAccess.Models;

public class CategoryDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public int CategoryID { get; set; }

    public string CategoryName { get; set; }

    public string Description { get; set; }

    public byte[] Picture { get; set; }
}