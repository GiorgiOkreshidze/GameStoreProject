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
        return (from t in gameDbContext.GenreEntities
            where t.Id == guid
            select t).First();
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        return gameDbContext.GenreEntities.AsNoTracking().ToList();
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        gameDbContext.Entry(updateGenreEntity).State = EntityState.Modified;
        gameDbContext.SaveChanges();
    }

    public void DeleteGenreDb(GenreEntity genreEntity)
    {
        gameDbContext.Entry(genreEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
         var entity = (from t in gameDbContext.GenreEntities
            where t.Id == id
            select t).First();

         return entity.GameEntities;
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return (from t in gameDbContext.GenreEntities
            where t.ParentGenreId == id
            select t).ToList();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GenreEntities.Any(t => t.Id == id);
    }

    public bool NameExists(string name)
    {
        return gameDbContext.GenreEntities.Any(t => t.Name == name);
    }
}