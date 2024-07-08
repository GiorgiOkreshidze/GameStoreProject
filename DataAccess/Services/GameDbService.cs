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
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.GameEntities.Add(gameEntity);
        gameDbContext.SaveChanges();
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        
        gameDbContext.AttachRange(gameEntity.PlatformEntities);
        gameDbContext.AttachRange(gameEntity.GenreEntities);
        gameDbContext.Entry(gameEntity).State = EntityState.Modified;
        gameDbContext.SaveChanges();
    }


   

    public void ClearGenresByGameId(Guid gameId)
    {
        var gameGenres = gameDbContext.GameGenres.Where(g => g.GameEntityId == gameId).ToList();
        
        foreach(var gameGenre in gameGenres)
        {
            gameDbContext.Remove(gameGenre);
        }

        gameDbContext.SaveChanges();
    }
    
    public void ClearPlatformsByGameId(Guid gameId)
    {
        var platforms = gameDbContext.GamePlatforms.Where(g => g.GameEntityId == gameId).ToList();
        
        foreach(var platform in platforms)
        {
            gameDbContext.Remove(platform);
        }

        gameDbContext.SaveChanges();
    }
    
    public void DeleteGameDb(GameEntity gameEntity)
    {
        gameDbContext.Entry(gameEntity).State = EntityState.Deleted;
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
    
    public PublisherEntity GetPublisherOfGameDb(string key)
    {
        var entity = (from t in gameDbContext.GameEntities.Include(x => x.PublisherEntity)
            where t.Key == key
            select t).First();
        
        return entity.PublisherEntity;
    }
    
    public bool NotExists(Guid id)
    {
        return !gameDbContext.GameEntities.Any(t => t.Id == id);
    }
    
    public bool KeyNotExists(string key)
    {
        return !gameDbContext.GameEntities.Any(t => t.Key == key);
    }
}