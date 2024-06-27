using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class GameDbService : IGameDbService
{
    private readonly GameDbContext _gameDbContext;
    
    public GameDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
    
    public ICollection<GameEntity> GetAllGamesDb()
    {
        return _gameDbContext.GameEntities.AsNoTracking().ToList();
    }
    
    public void CreateGameDb(GameEntity gameEntity)
    {
        _gameDbContext.AttachRange(gameEntity.GenreEntities);
        _gameDbContext.AttachRange(gameEntity.PlatformEntities);
        _gameDbContext.GameEntities.Add(gameEntity);
        _gameDbContext.SaveChanges();
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        var entity = _gameDbContext.GameEntities
            .Include(x => x.GenreEntities)
            .Include(x => x.PlatformEntities)
            .FirstOrDefault(x => x.Id == gameEntity.Id);

        entity.Description = gameEntity.Description;
        entity.Key = gameEntity.Key;
        entity.Name = gameEntity.Name;
        
        entity.GenreEntities.Clear();
        entity.PlatformEntities.Clear();
        _gameDbContext.SaveChanges();

        var genresToAdd = (
            from g in _gameDbContext.GenreEntities
            where gameEntity.GenreEntities.Select(ge => ge.Id).Contains(g.Id)
            select g).ToList();

        var platformsToAdd = (
            from p in _gameDbContext.PlatformEntities
            where gameEntity.PlatformEntities.Select(pe => pe.Id).Contains(p.Id)
            select p).ToList();
        
        entity.GenreEntities = genresToAdd;
        entity.PlatformEntities = platformsToAdd;
        
        // Question: When updating an entity should genres that are not in updated version of the entity be deleted from the entity too?
        /*foreach (var genre in gameEntity.GenreEntities)
        {
            var genreToAdd = _gameDbContext.GenreEntities.Find(genre.Id);
            if (genreToAdd != null)
            {
                entity.GenreEntities.Add(genreToAdd);
            }
            
        }
        // Same question here.
        foreach (var platform in gameEntity.PlatformEntities)
        {
            var platformToAdd = _gameDbContext.PlatformEntities.Find(platform.Id);
            if (platformToAdd != null)
            {
                entity.PlatformEntities.Add(platformToAdd);
            }
        }*/

        _gameDbContext.SaveChanges();
    }

    public void DeleteGameDb(string key)
    {
        var entity = (from t in _gameDbContext.GameEntities
            where t.Key == key
            select t).First();
        _gameDbContext.Entry(entity).State = EntityState.Deleted;
        _gameDbContext.SaveChanges();
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        
        return (from t in _gameDbContext.GameEntities
            where t.Key == key
            select t).First();
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        return (from t in _gameDbContext.GameEntities
            where t.Id == id
            select t).First();
    }

    public int GetGamesNumber()
    {
        return _gameDbContext.GameEntities.Count();
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        var entity = (from t in _gameDbContext.GameEntities.Include(x => x.GenreEntities)
            where t.Key == key
            select t).First();

        return entity.GenreEntities;
    }

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key)
    {
        var entity = (from t in _gameDbContext.GameEntities.Include(x => x.PlatformEntities)
            where t.Key == key
            select t).First();

        return entity.PlatformEntities;
    }
}