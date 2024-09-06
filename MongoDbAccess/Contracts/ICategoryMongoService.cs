using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface ICategoryMongoService
{
    public ICollection<CategoryDocument> GetAllMongo();

    public ICollection<CategoryDocument> GetAllMongoFiltered(ICollection<string> collection);

    public CategoryDocument GetCategoryByIdMongo(string id);

    public void CreateCategoryMongo(CategoryDocument category);

    public void UpdateCategoryMongo(CategoryDocument category);

    public void DeleteCategoryMongo(string id);

    public ICollection<ProductDocument> GetProductsByCategoryId(int categoryId);

    public ICollection<ProductDocument> GetProductsByCategoryIdFiltered(int categoryId, ICollection<string> collection);

    CategoryDocument GetCategoryByProductKey(string key);

    CategoryDocument GetCategoryByCategoryId(int categoryId);
}