using MongoDbAccess.Models;

namespace MongoDbAccess.Contracts;

public interface ICategoryMongoService
{
    public ICollection<CategoryDocument> GetAllMongo();

    public CategoryDocument GetCategoryByIdMongo(string id);

    public void CreateCategoryMongo(CategoryDocument category);

    public void UpdateCategoryMongo(CategoryDocument category);

    public void DeleteCategoryMongo(string id);
}