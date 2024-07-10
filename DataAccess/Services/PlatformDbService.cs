using System.Data.SqlTypes;
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
        gameDbContext.PlatformEntities.Update(platformEntity);
        gameDbContext.SaveChanges();
    }

    public void DeletePlatformDb(PlatformEntity platformEntity)
    {
        gameDbContext.Entry(platformEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public PlatformEntity GetPlatformByGuid(Guid id)
    {
        return gameDbContext.PlatformEntities.FirstOrDefault(t => t.Id == id)?? throw new SqlNullValueException();
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        return gameDbContext.PlatformEntities
            .Where(t => t.Id == id)
            .SelectMany(t => t.GameEntities)
            .ToList();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.PlatformEntities.Any(t => t.Id == id);
    }
    
    public bool TypeExists(string type)
    {
        return gameDbContext.PlatformEntities.Any(t => t.Type == type);
    }
}