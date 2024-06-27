using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class GenreDbService(GameDbContext gameDbContext) : IGenreDbService
{
    public void CreateGenreDb(GenreEntity genreEntity)
    {
        gameDbContext.GenreEntities.Add(genreEntity);
        gameDbContext.SaveChanges();
    }

    public GenreEntity GetGenreByGuid(Guid guid)
    { 
        return gameDbContext.Set<GenreEntity>().Where(g => g.Id == guid).FirstOrDefault();
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        return gameDbContext.GenreEntities.AsNoTracking().ToList();
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        var entity = gameDbContext.GenreEntities.First(x => x.Id == updateGenreEntity.Id);

        entity.Id = updateGenreEntity.Id;
        entity.Name = updateGenreEntity.Name;
        entity.ParentGenreId = updateGenreEntity.ParentGenreId;

        gameDbContext.SaveChanges();
    }

    public void DeleteGenreDb(Guid id)
    {
        var entity = (from t in gameDbContext.GenreEntities
            where t.Id == id
            select t).First();
        gameDbContext.Entry(entity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
        return (from t in gameDbContext.GameEntities
                where t.GenreEntities.Any(a => a.Id == id)
                select t).ToList();
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return (from t in gameDbContext.GenreEntities
            where t.ParentGenreId == id
            select t).ToList();
    }
}