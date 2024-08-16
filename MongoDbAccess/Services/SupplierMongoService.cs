using Microsoft.Extensions.Options;
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

    public void UpdateSupplierMongo(SupplierDocument updatedSupplier)
    {
        var result = _suppliersCollection.ReplaceOne(s => s.Id == updatedSupplier.Id, updatedSupplier);
        if (result.ModifiedCount == 0)
        {
            throw new InvalidOperationException("Failed to update product");
        }
    }

    public void DeleteSupplierMongo(string id)
    {
        var result = _suppliersCollection.DeleteOne(s => s.Id == id);
        if (result.DeletedCount == 0)
        {
            throw new InvalidOperationException("Failed to delete product");
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
}