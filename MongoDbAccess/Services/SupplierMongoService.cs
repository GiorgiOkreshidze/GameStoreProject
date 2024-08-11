using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace MongoDbAccess.Services;

public class SupplierMongoService : ISupplierMongoService
{
    private readonly IMongoCollection<SupplierDocument> _suppliersCollection;

    public SupplierMongoService(IOptions<MongoDbSettings> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _suppliersCollection = mongoDatabase.GetCollection<SupplierDocument>(dbSettings.Value.SuppliersCollectionName);
    }

    public void CreateSupplierMongo(SupplierDocument supplier)
    {
        _suppliersCollection.InsertOne(supplier);
    }

    public ICollection<SupplierDocument> GetAllSuppliersMongo()
    {
        return _suppliersCollection.Find(_ => true).ToList();
    }

    public SupplierDocument GetSupplierByIdMongo(string id)
    {
        return _suppliersCollection.Find(s => s.Id == id).FirstOrDefault()
               ?? throw new KeyNotFoundException("Supplier not found.");
    }

    public void UpdateSupplierMongo(string id, SupplierDocument updatedSupplier)
    {
        var result = _suppliersCollection.ReplaceOne(s => s.Id == id, updatedSupplier);
        if (result.MatchedCount == 0)
        {
            throw new KeyNotFoundException("Supplier not found.");
        }
    }

    public void DeleteSupplierMongo(string id)
    {
        var result = _suppliersCollection.DeleteOne(s => s.Id == id);
        if (result.DeletedCount == 0)
        {
            throw new KeyNotFoundException("Supplier not found.");
        }
    }
}