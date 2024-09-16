using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class SupplierMongoService : ISupplierMongoService
{
    private readonly IMongoCollection<SupplierDocument> _suppliersCollection;
    private readonly IMongoCollection<ProductDocument> _productsCollection;

    public SupplierMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _suppliersCollection = mongoDatabase.GetCollection<SupplierDocument>(dbSettings.Value.SuppliersCollectionName);
        _productsCollection = mongoDatabase.GetCollection<ProductDocument>(dbSettings.Value.ProductsCollectionName);
    }

    public SupplierDocument GetSupplierByCompanyName(string companyName)
    {
        return _suppliersCollection.Find(s => s.CompanyName == companyName).FirstOrDefault();
    }

    public SupplierDocument GetSupplierById(string supplierId)
    {
        return _suppliersCollection.Find(s => s.Id == supplierId).FirstOrDefault();
    }

    public void CreateSupplierMongo(SupplierDocument supplier)
    {
        if (!ObjectId.TryParse(supplier.Id, out _))
        {
            supplier.Id = ObjectId.GenerateNewId().ToString();
        }

        var insertCommand = new BsonDocument
        {
            { "insert", _suppliersCollection.CollectionNamespace.CollectionName },
            { "documents", new BsonArray { supplier.ToBsonDocument() } },
        };

        _suppliersCollection.Database.RunCommand<BsonDocument>(insertCommand);
    }

    public ICollection<SupplierDocument> GetAllSuppliersMongo()
    {
        return _suppliersCollection.Find(_ => true).ToList();
    }

    public ICollection<SupplierDocument> GetSuppliersFiltered(ICollection<string> collection)
    {
        return _suppliersCollection.Find(a => !collection.Contains(a.Id)).ToList();
    }

    public SupplierDocument GetSupplierByIdMongo(string id)
    {
        return _suppliersCollection.Find(s => s.Id == id).FirstOrDefault()
               ?? throw new KeyNotFoundException("Supplier not found.");
    }

    public void UpdateSupplierMongo(SupplierDocument updatedSupplier)
    {
        var updateCommand = new BsonDocument
        {
            { "update", _suppliersCollection.CollectionNamespace.CollectionName },
            {
                "updates", new BsonArray
                {
                    new BsonDocument
                    {
                        { "q", new BsonDocument { { "_id", new ObjectId(updatedSupplier.Id) } } },
                        { "u", updatedSupplier.ToBsonDocument() },
                        { "upsert", false },
                    },
                }
            },
        };

        var updateResult = _suppliersCollection.Database.RunCommand<BsonDocument>(updateCommand);
        var modifiedCount = updateResult["nModified"].AsInt32;
        if (modifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update supplier");
        }
    }

    public void DeleteSupplierMongo(string id)
    {
        var deleteCommand = new BsonDocument
        {
            { "delete", _suppliersCollection.CollectionNamespace.CollectionName },
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

        var deleteResult = _suppliersCollection.Database.RunCommand<BsonDocument>(deleteCommand);
        var deletedCount = deleteResult["n"].AsInt32;
        if (deletedCount == 0)
        {
            throw new InvalidOperationException("Failed to delete supplier");
        }
    }

    public bool CompanyNameNotExists(string companyName)
    {
        return !_suppliersCollection.Find(s => s.CompanyName == companyName).Any();
    }

    public ICollection<ProductDocument> GetProductsBySupplierId(int supplierId)
    {
        return _productsCollection.Find(p => p.SupplierID == supplierId).ToList();
    }

    public ICollection<ProductDocument> GetProductsBySupplierIdFiltered(int supplierId, ICollection<string> collection)
    {
        return _productsCollection.Find(p => p.SupplierID == supplierId && !collection.Contains(p.Id)).ToList();
    }

    public SupplierDocument GetPublisherByGameKey(string gameKey)
    {
        int supplierId = _productsCollection.Find(p => p.GameKey == gameKey).FirstOrDefault().SupplierID;
        return _suppliersCollection.Find(s => s.SupplierID == supplierId).FirstOrDefault();
    }

    public SupplierDocument GetSupplierBySupplierId(int supplierId)
    {
        return _suppliersCollection.Find(s => s.SupplierID == supplierId).FirstOrDefault();
    }
}