using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface ISupplierMongoService
{
    public void CreateSupplierMongo(SupplierDocument supplier);

    public ICollection<SupplierDocument> GetAllSuppliersMongo();

    public SupplierDocument GetSupplierByIdMongo(string id);

    public void UpdateSupplierMongo(string id, SupplierDocument updatedSupplier);

    public void DeleteSupplierMongo(string id);
}