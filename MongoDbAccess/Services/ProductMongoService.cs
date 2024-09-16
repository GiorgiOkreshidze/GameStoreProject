using Microsoft.Extensions.Options;
using MongoDB.Bson;

// using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
using MongoDbAccess.MongoDTOs;

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

    public ICollection<ProductDocument> GetAllMongo(ProductMongoFilter filter)
    {
        var filterBuilder = Builders<ProductDocument>.Filter;
        var filterDefinition = filterBuilder.Empty;

        if (!FilterIsDefault(filter))
        {
            if (filter.ExcludeProducts is not null)
            {
                if (filter.ExcludeProducts.Any())
                {
                    var categoryFilter = filterBuilder.Nin(doc => doc.Id, filter.ExcludeProducts);
                    filterDefinition = filterBuilder.And(filterDefinition, categoryFilter);
                }
            }

            if (filter.Categories is not null)
            {
                ICollection<int> categoryIntIDs = [];
                foreach (var categoryId in filter.Categories)
                {
                    categoryIntIDs.Add(_categoryCollection.Find(c => c.Id == categoryId).FirstOrDefault().CategoryID);
                }

                if (categoryIntIDs.Any())
                {
                    var categoryFilter = filterBuilder.In(doc => doc.CategoryID, categoryIntIDs);
                    filterDefinition = filterBuilder.And(filterDefinition, categoryFilter);
                }
            }

            if (filter.Suppliers is not null)
            {
                ICollection<int> supplierIntIDs = [];
                foreach (var supplierId in filter.Suppliers)
                {
                    supplierIntIDs.Add(_supplierCollection.Find(c => c.Id == supplierId).FirstOrDefault().SupplierID);
                }

                if (supplierIntIDs.Any())
                {
                    var publisherFilter = filterBuilder.In(doc => doc.SupplierID, supplierIntIDs);
                    filterDefinition = filterBuilder.And(filterDefinition, publisherFilter);
                }
            }

            if (filter.MinPrice.HasValue)
            {
                var minPriceFilter = filterBuilder.Gte(doc => doc.UnitPrice, filter.MinPrice.Value);
                filterDefinition = filterBuilder.And(filterDefinition, minPriceFilter);
            }

            if (filter.MaxPrice.HasValue)
            {
                var maxPriceFilter = filterBuilder.Lte(doc => doc.UnitPrice, filter.MaxPrice.Value);
                filterDefinition = filterBuilder.And(filterDefinition, maxPriceFilter);
            }

            if (!string.IsNullOrEmpty(filter.Name) && filter.Name.Length >= 3)
            {
                var nameFilter = filterBuilder.Regex(doc => doc.ProductName, new BsonRegularExpression(filter.Name, "i"));
                filterDefinition = filterBuilder.And(filterDefinition, nameFilter);
            }
        }

        return _productsCollection.Find(filterDefinition).ToList();
    }

    public static bool FilterIsDefault(ProductMongoFilter filterDto) => (filterDto.Suppliers == null || !filterDto.Suppliers.Any())
                                                                   && (filterDto.Categories == null || !filterDto.Categories.Any())
                                                                   && (filterDto.ExcludeProducts == null || !filterDto.ExcludeProducts.Any())
                                                                   && !filterDto.MinPrice.HasValue
                                                                   && !filterDto.MaxPrice.HasValue
                                                                   && string.IsNullOrEmpty(filterDto.Name);

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

        if (!ObjectId.TryParse(productDocument.Id, out _))
        {
            productDocument.Id = ObjectId.GenerateNewId().ToString();
        }

        var insertCommand = new BsonDocument
        {
            { "insert", _productsCollection.CollectionNamespace.CollectionName },
            { "documents", new BsonArray { productDocument.ToBsonDocument() } },
        };

        _productsCollection.Database.RunCommand<BsonDocument>(insertCommand);
    }

    public void UpdateProduct(ProductDocument productDocument)
    {
        var updateCommand = new BsonDocument
        {
            { "update", _productsCollection.CollectionNamespace.CollectionName },
            {
                "updates", new BsonArray
                {
                    new BsonDocument
                    {
                        { "q", new BsonDocument { { "_id", new ObjectId(productDocument.Id) } } },
                        { "u", productDocument.ToBsonDocument() },
                        { "upsert", false },
                    },
                }
            },
        };

        var updateResult = _productsCollection.Database.RunCommand<BsonDocument>(updateCommand);
        var modifiedCount = updateResult["nModified"].AsInt32;
        if (modifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update product");
        }
    }

    public void DeleteProduct(string id)
    {
        var deleteCommand = new BsonDocument
        {
            { "delete", _productsCollection.CollectionNamespace.CollectionName },
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

        var deleteResult = _productsCollection.Database.RunCommand<BsonDocument>(deleteCommand);
        var deletedCount = deleteResult["n"].AsInt32;
        if (deletedCount == 0)
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

    public ICollection<ProductDocument> GetAllWithoutFilterMongo()
    {
        return _productsCollection.Find(_ => true).ToList();
    }
}