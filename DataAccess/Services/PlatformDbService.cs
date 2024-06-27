using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class PlatformDbService : IPlatformDbService
{
    private GameDbContext _gameDbContext;
    
    public PlatformDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }

    public void CreatePlatformDb(PlatformEntity platformEntity)
    {
        _gameDbContext.PlatformEntities.Add(platformEntity);
        _gameDbContext.SaveChanges();
    }

    public ICollection<PlatformEntity> GetAllPlatformsDb()
    {
        return _gameDbContext.PlatformEntities.AsNoTracking().ToList();
    }

    public void UpdatePlatformDb(PlatformEntity platformEntity)
    {
        var entity = _gameDbContext.PlatformEntities.First(x => x.Id == platformEntity.Id);

        entity.Id = platformEntity.Id;
        entity.Type = platformEntity.Type;

        _gameDbContext.SaveChanges();
    }

    public void DeletePlatformDb(Guid id)
    {
        var entity = (from t in _gameDbContext.PlatformEntities
            where t.Id == id
            select t).First();
        _gameDbContext.Entry(entity).State = EntityState.Deleted;
        _gameDbContext.SaveChanges();
    }

    public PlatformEntity GetPlatformByGuid(Guid guid)
    {
        return _gameDbContext.Set<PlatformEntity>().Where(g => g.Id == guid).First();;
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        var platform = (from t in _gameDbContext.GameEntities
            where t.PlatformEntities.Any(a => a.Id == id)
            select t).ToList();

        return platform;
    }
}