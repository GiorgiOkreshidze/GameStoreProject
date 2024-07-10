using System.Data.SqlTypes;
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
        return gameDbContext.GenreEntities.FirstOrDefault(t => t.Id == guid)?? throw new SqlNullValueException();
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
        return !gameDbContext.GenreEntities.Any(t => t.Id == id);
    }

    public bool NameExists(string name)
    {
        return gameDbContext.GenreEntities.Any(t => t.Name == name);
    }
}