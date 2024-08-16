using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class CategoryMongoService : ICategoryMongoService
{
    private readonly IMongoCollection<CategoryDocument> _categoriesCollection;
    private readonly IMongoCollection<ProductDocument> _productsCollection;

    public CategoryMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _categoriesCollection = mongoDatabase.GetCollection<CategoryDocument>(dbSettings.Value.CategoriesCollectionName);
        _productsCollection = mongoDatabase.GetCollection<ProductDocument>(dbSettings.Value.ProductsCollectionName);
    }

    public ICollection<CategoryDocument> GetAllMongo()
    {
        return _categoriesCollection.Find(_ => true).ToList();
    }

    public CategoryDocument GetCategoryByIdMongo(string id)
    {
        return _categoriesCollection.Find(category => category.Id == id).FirstOrDefault();
    }

    public void CreateCategoryMongo(CategoryDocument category)
    {
        _categoriesCollection.InsertOne(category);
    }

    public void UpdateCategoryMongo(CategoryDocument category)
    {
        var result = _categoriesCollection.ReplaceOne(cat => cat.Id == category.Id, category);
        if (result.ModifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update the category.");
        }
    }

    public void DeleteCategoryMongo(string id)
    {
        var result = _categoriesCollection.DeleteOne(cat => cat.Id == id);
        if (result.DeletedCount == 0)
        {
            throw new InvalidOperationException("Failed to delete the category.");
        }
    }

    public ICollection<ProductDocument> GetProductsByCategoryId(int categoryId)
    {
        return _productsCollection.Find(p => p.CategoryID == categoryId).ToList();
    }
}