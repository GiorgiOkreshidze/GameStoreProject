using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IGenreDbService
{
    public void CreateGenreDb(GenreEntity genreEntity);

    public GenreEntity GetGenreByGuid(Guid id);

    public ICollection<GenreEntity> GetAllGenresDb();

    public void UpdateGenreDb(GenreEntity updateGenreEntity);

    public void DeleteGenreDb(GenreEntity genreEntity);

    public ICollection<GameEntity> GetGamesByGenreId(Guid id);

    public ICollection<GenreEntity> GetSubGenresDb(Guid id);

    public bool NotExists(Guid id);

    public bool NameExists(string name);
}