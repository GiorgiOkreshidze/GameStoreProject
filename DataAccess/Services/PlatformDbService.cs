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
        gameDbContext.Entry(platformEntity).State = EntityState.Modified;
        gameDbContext.SaveChanges();
    }

    public void DeletePlatformDb(PlatformEntity platformEntity)
    {
        gameDbContext.Entry(platformEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public PlatformEntity GetPlatformByGuid(Guid id)
    {
        return (from t in gameDbContext.PlatformEntities
            where t.Id == id
            select t).First();
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        
        var platform = (from t in gameDbContext.PlatformEntities
            where t.Id == id
            select t).First();

        return platform.GameEntities;
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.GenreEntities.Any(t => t.Id == id);
    }
    
    public bool TypeExists(string type)
    {
        return gameDbContext.PlatformEntities.Any(t => t.Type == type);
    }
}