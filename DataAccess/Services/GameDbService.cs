using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class GameDbService(GameDbContext gameDbContext) : IGameDbService
{
    public ICollection<GameEntity> GetAllGamesDb()
    {
        return gameDbContext.GameEntities.AsNoTracking().ToList();
    }
    
    public void CreateGameDb(GameEntity gameEntity)
    {
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.GameEntities.Add(gameEntity);
        gameDbContext.SaveChanges();
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        var entity = gameDbContext.GameEntities
            .Include(x => x.GenreEntities)
            .Include(x => x.PlatformEntities)
            .FirstOrDefault(x => x.Id == gameEntity.Id);

        entity.Description = gameEntity.Description;
        entity.Key = gameEntity.Key;
        entity.Name = gameEntity.Name;
        
        entity.GenreEntities.Clear();
        entity.PlatformEntities.Clear();
        gameDbContext.SaveChanges();

        var genresToAdd = (
            from g in gameDbContext.GenreEntities
            where gameEntity.GenreEntities.Select(ge => ge.Id).Contains(g.Id)
            select g).ToList();

        var platformsToAdd = (
            from p in gameDbContext.PlatformEntities
            where gameEntity.PlatformEntities.Select(pe => pe.Id).Contains(p.Id)
            select p).ToList();
        
        entity.GenreEntities = genresToAdd;
        entity.PlatformEntities = platformsToAdd;

        gameDbContext.SaveChanges();
    }

    public void DeleteGameDb(string key)
    {
        var entity = (from t in gameDbContext.GameEntities
            where t.Key == key
            select t).First();
        gameDbContext.Entry(entity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        
        return (from t in gameDbContext.GameEntities
            where t.Key == key
            select t).First();
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        return (from t in gameDbContext.GameEntities
            where t.Id == id
            select t).First();
    }

    public int GetGamesNumber()
    {
        return gameDbContext.GameEntities.Count();
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        var entity = (from t in gameDbContext.GameEntities.Include(x => x.GenreEntities)
            where t.Key == key
            select t).First();

        return entity.GenreEntities;
    }

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key)
    {
        var entity = (from t in gameDbContext.GameEntities.Include(x => x.PlatformEntities)
            where t.Key == key
            select t).First();

        return entity.PlatformEntities;
    }
}