namespace DataAccess.Entities;

public class DatabaseIds
{
    public Guid Id { get; set; }

    public string MongoId { get; set; }

    public bool Synchronized { get; set; }

    public string ObjectType { get; set; }

    public int? ViewCount { get; set; }

    public bool Deleted { get; set; }
}