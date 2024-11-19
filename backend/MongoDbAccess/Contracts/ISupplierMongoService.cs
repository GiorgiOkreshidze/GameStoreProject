using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface ISupplierMongoService
{
    public SupplierDocument GetSupplierByCompanyName(string companyName);

    public SupplierDocument GetSupplierById(string supplierId);

    public void CreateSupplierMongo(SupplierDocument supplier);

    public ICollection<SupplierDocument> GetAllSuppliersMongo();

    public ICollection<SupplierDocument> GetSuppliersFiltered(ICollection<string> collection);

    public SupplierDocument GetSupplierByIdMongo(string id);

    public void UpdateSupplierMongo(SupplierDocument updatedSupplier);

    public void DeleteSupplierMongo(string id);

    public bool CompanyNameNotExists(string companyName);

    public ICollection<ProductDocument> GetProductsBySupplierId(int supplierId);

    public ICollection<ProductDocument> GetProductsBySupplierIdFiltered(int supplierId, ICollection<string> collection);

    public SupplierDocument GetPublisherByGameKey(string gameKey);

    public SupplierDocument GetSupplierBySupplierId(int supplierId);
}