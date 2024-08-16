using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface IProductMongoService
{
    public ICollection<ProductDocument> GetAllMongo();

    public ProductDocument GetProductByIdMongo(string id);

    public void CreateProduct(ProductDocument productDocument);

    public void UpdateProduct(ProductDocument productDocument);

    public void DeleteProduct(string id);

    public SupplierDocument GetSupplierOfProduct(int supplierId);

    public CategoryDocument GetCategoryOfProduct(int categoryId);

    public bool KeyNotExists(string key);

    public ProductDocument GetProductByGameKey(string key);
}