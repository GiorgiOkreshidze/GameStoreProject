namespace MongoDbAccess.MongoDTOs;

public class ProductMongoFilter
{
    public ICollection<string>? ExcludeProducts { get; set; }

    public ICollection<string>? Categories { get; set; }

    public ICollection<string>? Suppliers { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public string? Name { get; set; }
}