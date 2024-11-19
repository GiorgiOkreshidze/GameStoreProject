using Microsoft.Extensions.Options;
using MongoDB.Bson;
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

    public ICollection<CategoryDocument> GetAllMongoFiltered(ICollection<string> collection)
    {
        return _categoriesCollection.Find(a => !collection.Contains(a.Id)).ToList();
    }

    public CategoryDocument GetCategoryByIdMongo(string id)
    {
        return _categoriesCollection.Find(category => category.Id == id).FirstOrDefault();
    }

    public void CreateCategoryMongo(CategoryDocument category)
    {
        if (!ObjectId.TryParse(category.Id, out _))
        {
            category.Id = ObjectId.GenerateNewId().ToString();
        }

        var insertCommand = new BsonDocument
        {
            { "insert", _categoriesCollection.CollectionNamespace.CollectionName },
            { "documents", new BsonArray { category.ToBsonDocument() } },
        };

        _categoriesCollection.Database.RunCommand<BsonDocument>(insertCommand);
    }

    public void UpdateCategoryMongo(CategoryDocument category)
    {
        var updateCommand = new BsonDocument
        {
            { "update", _categoriesCollection.CollectionNamespace.CollectionName },
            {
                "updates", new BsonArray
                {
                    new BsonDocument
                    {
                        { "q", new BsonDocument { { "_id", new ObjectId(category.Id) } } },
                        { "u", category.ToBsonDocument() },
                        { "upsert", false },
                    },
                }
            },
        };

        var updateResult = _categoriesCollection.Database.RunCommand<BsonDocument>(updateCommand);
        var modifiedCount = updateResult["nModified"].AsInt32;
        if (modifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update the category.");
        }
    }

    public void DeleteCategoryMongo(string id)
    {
        var deleteCommand = new BsonDocument
        {
            { "delete", _categoriesCollection.CollectionNamespace.CollectionName },
            {
                "deletes", new BsonArray
                {
                    new BsonDocument
                    {
                        { "q", new BsonDocument { { "_id", new ObjectId(id) } } },
                        { "limit", 1 },
                    },
                }
            },
        };

        var deleteResult = _categoriesCollection.Database.RunCommand<BsonDocument>(deleteCommand);
        var deletedCount = deleteResult["n"].AsInt32;
        if (deletedCount == 0)
        {
            throw new InvalidOperationException("Failed to delete the category.");
        }
    }

    public ICollection<ProductDocument> GetProductsByCategoryId(int categoryId)
    {
        return _productsCollection.Find(p => p.CategoryID == categoryId).ToList();
    }

    public ICollection<ProductDocument> GetProductsByCategoryIdFiltered(int categoryId, ICollection<string> collection)
    {
        return _productsCollection.Find(p => p.CategoryID == categoryId && !collection.Contains(p.Id)).ToList();
    }

    public CategoryDocument GetCategoryByProductKey(string key)
    {
        var document = _productsCollection.Find(p => p.GameKey == key).FirstOrDefault() ?? new ProductDocument();
        int categoryId = document.CategoryID;
        return _categoriesCollection.Find(s => s.CategoryID == categoryId).FirstOrDefault();
    }

    public CategoryDocument GetCategoryByCategoryId(int categoryId)
    {
        return _categoriesCollection.Find(s => s.CategoryID == categoryId).FirstOrDefault();
    }
}