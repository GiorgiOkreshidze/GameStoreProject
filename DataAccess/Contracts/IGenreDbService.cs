using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IGenreDbService
{
    public void CreateGenreDb(GenreEntity genreEntity);
    
    public GenreEntity GetGenreByGuid(Guid guid);

    public ICollection<GenreEntity> GetAllGenresDb();

    public void UpdateGenreDb(GenreEntity updateGenreEntity);

    public void DeleteGenreDb(Guid id);
    
    public ICollection<GameEntity> GetGamesByGenreId(Guid id);

    public ICollection<GenreEntity> GetSubGenresDb(Guid id);
}