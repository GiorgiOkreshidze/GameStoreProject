using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbAccess.Models;

public class ChangeLogDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string EntityName { get; set; }

    public string Action { get; set; } // e.g., "Insert", "Update", "Delete"

    public string User { get; set; }

    public DateTime Timestamp { get; set; }

    public string Details { get; set; }
}