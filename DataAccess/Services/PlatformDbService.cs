using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class PlatformDbService(GameDbContext gameDbContext) : IPlatformDbService
{
    public void CreatePlatformDb(PlatformEntity platformEntity)
    {
        gameDbContext.PlatformEntities.Add(platformEntity);
        gameDbContext.SaveChanges();
    }

    public ICollection<PlatformEntity> GetAllPlatformsDb()
    {
        return gameDbContext.PlatformEntities.AsNoTracking().ToList();
    }

    public void UpdatePlatformDb(PlatformEntity platformEntity)
    {
        var entity = gameDbContext.PlatformEntities.First(x => x.Id == platformEntity.Id);

        entity.Id = platformEntity.Id;
        entity.Type = platformEntity.Type;

        gameDbContext.SaveChanges();
    }

    public void DeletePlatformDb(Guid id)
    {
        var entity = (from t in gameDbContext.PlatformEntities
            where t.Id == id
            select t).First();
        gameDbContext.Entry(entity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public PlatformEntity GetPlatformByGuid(Guid guid)
    {
        return gameDbContext.Set<PlatformEntity>().Where(g => g.Id == guid).First();;
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        var platform = (from t in gameDbContext.GameEntities
            where t.PlatformEntities.Any(a => a.Id == id)
            select t).ToList();

        return platform;
    }
}