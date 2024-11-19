using DataAccess.Contracts;
using DataAccess.Entities;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class GenreDbServiceLoggingDecorator(IGenreDbService genreDbService, IChangeLogMongoService logMongoService) : IGenreDbService
{
    private const string EntityName = "Genre";

    public void CreateGenreDb(GenreEntity genreEntity)
    {
        genreDbService.CreateGenreDb(genreEntity);
        logMongoService.LogChange(EntityName, "Add Genre", null, genreEntity);
    }

    public GenreEntity GetGenreByGuid(Guid id)
    {
        return genreDbService.GetGenreByGuid(id);
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        return genreDbService.GetAllGenresDb();
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        var oldGenreEntity = genreDbService.GetGenreByGuid(updateGenreEntity.Id);
        genreDbService.UpdateGenreDb(updateGenreEntity);
        logMongoService.LogChange(EntityName, "Update Genre", oldGenreEntity, updateGenreEntity);
    }

    public void DeleteGenreDb(GenreEntity genreEntity)
    {
        genreDbService.DeleteGenreDb(genreEntity);
        logMongoService.LogChange(EntityName, "Delete Genre", genreEntity, null);
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return genreDbService.GetSubGenresDb(id);
    }

    public bool NotExists(Guid id)
    {
        return genreDbService.NotExists(id);
    }

    public bool NameExists(string name)
    {
        return genreDbService.NameExists(name);
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        return genreDbService.GetGenresOfGameDb(key);
    }
}