using Microsoft.Extensions.Options;

// using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class ProductMongoService : IProductMongoService
{
    private readonly IMongoCollection<ProductDocument> _productsCollection;
    private readonly IMongoCollection<SupplierDocument> _supplierCollection;
    private readonly IMongoCollection<CategoryDocument> _categoryCollection;

    public ProductMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _productsCollection = mongoDatabase.GetCollection<ProductDocument>(dbSettings.Value.ProductsCollectionName);
        _supplierCollection = mongoDatabase.GetCollection<SupplierDocument>(dbSettings.Value.SuppliersCollectionName);
        _categoryCollection = mongoDatabase.GetCollection<CategoryDocument>(dbSettings.Value.CategoriesCollectionName);
    }

    public ICollection<ProductDocument> GetAllMongo()
    {
        return _productsCollection.Find(_ => true).ToList();
    }

    public ProductDocument GetProductByIdMongo(string id)
    {
        var filter = Builders<ProductDocument>.Filter.Eq(p => p.Id, id);
        var update = Builders<ProductDocument>.Update.Inc(p => p.Views, 1);

        var updatedProduct = _productsCollection.FindOneAndUpdate(filter, update);

        return updatedProduct ?? throw new KeyNotFoundException("Product not found.");
    }

    public void CreateProduct(ProductDocument productDocument)
    {
        productDocument.Views = 0;
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

    public SupplierDocument GetSupplierOfProduct(int supplierId)
    {
        return _supplierCollection.Find(s => s.SupplierID == supplierId).FirstOrDefault();
    }

    public CategoryDocument GetCategoryOfProduct(int categoryId)
    {
        return _categoryCollection.Find(c => c.CategoryID == categoryId).FirstOrDefault();
    }

    public bool KeyNotExists(string key)
    {
        return !_productsCollection.Find(p => p.GameKey == key).Any();
    }

    public ProductDocument GetProductByGameKey(string key)
    {
        var filter = Builders<ProductDocument>.Filter.Eq(p => p.GameKey, key);
        var update = Builders<ProductDocument>.Update.Inc(p => p.Views, 1);

        var updatedProduct = _productsCollection.FindOneAndUpdate(filter, update);

        return updatedProduct;
    }
}