using Microsoft.Extensions.Options;

// using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class ProductMongoService : IProductMongoService
{
    private readonly IMongoCollection<ProductDocument> _productsCollection;

    public ProductMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _productsCollection = mongoDatabase.GetCollection<ProductDocument>(dbSettings.Value.ProductsCollectionName);
    }

    public ICollection<ProductDocument> GetAllMongo()
    {
        return _productsCollection.Find(_ => true).ToList();
    }

    public ProductDocument GetProductByIdMongo(string id)
    {
        var filter = Builders<ProductDocument>.Filter.Eq(p => p.Id, id);
        var update = Builders<ProductDocument>.Update.Inc(p => p.ViewCount, 1);

        var updatedProduct = _productsCollection.FindOneAndUpdate(filter, update);

        return updatedProduct ?? throw new KeyNotFoundException("Product not found.");
    }

    public void CreateProduct(ProductDocument productDocument)
    {
        productDocument.ViewCount = 0;
        _productsCollection.InsertOne(productDocument);
    }

    public void UpdateProduct(ProductDocument productDocument)
    {
        var updateResult = _productsCollection.ReplaceOne(p => p.Id == productDocument.Id, productDocument);
        if (updateResult.ModifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update product");
        }
    }

    public void DeleteProduct(string id)
    {
        var deleteResult = _productsCollection.DeleteOne(p => p.Id == id);
        if (deleteResult.DeletedCount == 0)
        {
            throw new InvalidOperationException("Failed to delete product");
        }
    }

    public void BuyProduct(string productId, int quantity)
    {
        var product = GetProductByIdMongo(productId);
        if (product.UnitsInStock < quantity)
        {
            throw new InvalidOperationException("Insufficient stock available");
        }

        // Update the product stock
        var update = Builders<ProductDocument>.Update
            .Set(p => p.UnitsInStock, product.UnitsInStock - quantity);
        var updateResult = _productsCollection.UpdateOne(p => p.Id == productId, update);
        if (updateResult.ModifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to purchase product");
        }
    }

    /*public (ICollection<ProductDocument> Products, long TotalCount) GetSortedAndPagedProducts(ProductFilterDto filter, ProductSortDto sort, ProductPaginationDto pagination)
    {
        var query = Builders<ProductDocument>.Filter.Empty;

        // Apply filters
        if (filter.MinPrice.HasValue)
        {
            query &= Builders<ProductDocument>.Filter.Gte(p => p.UnitPrice, filter.MinPrice.Value);
        }

        if (filter.MaxPrice.HasValue)
        {
            query &= Builders<ProductDocument>.Filter.Lte(p => p.UnitPrice, filter.MaxPrice.Value);
        }

        if (filter.CategoryIds != null && filter.CategoryIds.Any())
        {
            query &= Builders<ProductDocument>.Filter.In(p => p.CategoryID, filter.CategoryIds);
        }

        if (filter.SupplierIds != null && filter.SupplierIds.Any())
        {
            query &= Builders<ProductDocument>.Filter.In(p => p.SupplierID, filter.SupplierIds);
        }

        if (!string.IsNullOrEmpty(filter.Name) && filter.Name.Length >= 3)
        {
            query &= Builders<ProductDocument>.Filter.Regex(p => p.ProductName, new BsonRegularExpression(filter.Name, "i"));
        }

        // Get total count for pagination
        var totalCount = _productsCollection.CountDocuments(query);

        // Apply sorting
        var sortDefinition = sort.SortBy switch
        {
            "Name ASC" => Builders<ProductDocument>.Sort.Ascending(p => p.ProductName),
            "Name DESC" => Builders<ProductDocument>.Sort.Descending(p => p.ProductName),
            "Price ASC" => Builders<ProductDocument>.Sort.Ascending(p => p.UnitPrice),
            "Price DESC" => Builders<ProductDocument>.Sort.Descending(p => p.UnitPrice),
            _ => Builders<ProductDocument>.Sort.Ascending(p => p.ProductID), // Default sort
        };

        // Apply pagination
        var products = _productsCollection.Find(query)
            .Sort(sortDefinition)
            .Skip((pagination.PageNumber - 1) * pagination.PageSize)
            .Limit(pagination.PageSize)
            .ToList();

        return (products, totalCount);
    }*/
}