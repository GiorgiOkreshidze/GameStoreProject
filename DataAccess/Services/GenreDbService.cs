using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class GenreDbService : IGenreDbService
{
    private GameDbContext _gameDbContext;
    
    public GenreDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }

    public void CreateGenreDb(GenreEntity genreEntity)
    {
        _gameDbContext.GenreEntities.Add(genreEntity);
        _gameDbContext.SaveChanges();
    }

    public GenreEntity GetGenreByGuid(Guid guid)
    { 
        return _gameDbContext.Set<GenreEntity>().Where(g => g.Id == guid).FirstOrDefault();
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        return _gameDbContext.GenreEntities.AsNoTracking().ToList();
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        var entity = _gameDbContext.GenreEntities.First(x => x.Id == updateGenreEntity.Id);

        entity.Id = updateGenreEntity.Id;
        entity.Name = updateGenreEntity.Name;
        entity.ParentGenreId = updateGenreEntity.ParentGenreId;

        _gameDbContext.SaveChanges();
    }

    public void DeleteGenreDb(Guid id)
    {
        var entity = (from t in _gameDbContext.GenreEntities
            where t.Id == id
            select t).First();
        _gameDbContext.Entry(entity).State = EntityState.Deleted;
        _gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
        return (from t in _gameDbContext.GameEntities
                where t.GenreEntities.Any(a => a.Id == id)
                select t).ToList();
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return (from t in _gameDbContext.GenreEntities
            where t.ParentGenreId == id
            select t).ToList();
    }
}