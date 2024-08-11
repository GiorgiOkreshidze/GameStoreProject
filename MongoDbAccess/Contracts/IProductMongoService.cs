using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface IProductMongoService
{
    public ICollection<ProductDocument> GetAllMongo();

    public ProductDocument GetProductByIdMongo(string id);

    public void CreateProduct(ProductDocument productDocument);

    public void UpdateProduct(ProductDocument productDocument);

    public void DeleteProduct(string id);

    public void BuyProduct(string productId, int quantity);
}