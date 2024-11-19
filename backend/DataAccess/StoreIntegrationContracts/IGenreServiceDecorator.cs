using DataAccess.Entities;

namespace DataAccess.StoreIntegrationContracts;

public interface IGenreServiceDecorator
{
    public GenreEntity GetGenreByMongoId(int categoryId);

    public void TransferCategoryToDatabase(Guid id);

    public void TransferCategoryToDatabase(GenreEntity genreEntity);
}