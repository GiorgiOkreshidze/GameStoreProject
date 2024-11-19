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

    public string Picture { get; set; }

    [BsonElement("field4")]
    [BsonIgnoreIfNull]
    public string Field4 { get; set; }
}