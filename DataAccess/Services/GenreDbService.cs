using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class GenreDbService(GameDbContext gameDbContext) : IGenreDbService
{
    public void CreateGenreDb(GenreEntity genreEntity)
    {
        gameDbContext.GenreEntities.Add(genreEntity);
        gameDbContext.SaveChanges();

        var gameEntry = gameDbContext.Entry(genreEntity);
        if (gameEntry.State != EntityState.Detached)
        {
            gameEntry.State = EntityState.Detached;
        }
    }

    public GenreEntity GetGenreByGuid(Guid id)
    {
        return gameDbContext.GenreEntities.FirstOrDefault(t => t.Id == id);
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        return gameDbContext.GenreEntities.AsNoTracking().ToList();
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        gameDbContext.GenreEntities.Update(updateGenreEntity);
        gameDbContext.SaveChanges();
    }

    public void DeleteGenreDb(GenreEntity genreEntity)
    {
        gameDbContext.Entry(genreEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
        return gameDbContext.GenreEntities
            .Where(t => t.Id == id)
            .SelectMany(t => t.GameEntities)
            .ToList();
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return gameDbContext.GenreEntities
            .Where(t => t.ParentGenreId == id)
            .ToList();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GenreEntities.AsNoTracking().Any(t => t.Id == id);
    }

    public bool NameExists(string name)
    {
        return gameDbContext.GenreEntities.Any(t => t.Name == name);
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        var genres = gameDbContext.GenreEntities.Where(g => g.GameEntities.Any(e => e.Key == key)).ToList();

        return genres;
    }
}