using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface ISupplierMongoService
{
    public SupplierDocument GetSupplierByCompanyName(string companyName);

    public void CreateSupplierMongo(SupplierDocument supplier);

    public ICollection<SupplierDocument> GetAllSuppliersMongo();

    public SupplierDocument GetSupplierByIdMongo(string id);

    public void UpdateSupplierMongo(SupplierDocument updatedSupplier);

    public void DeleteSupplierMongo(string id);

    public bool CompanyNameNotExists(string companyName);

    public ICollection<ProductDocument> GetProductsBySupplierId(int supplierId);
}