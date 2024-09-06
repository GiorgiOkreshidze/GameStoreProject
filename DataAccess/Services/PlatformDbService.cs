using System.Data.SqlTypes;
using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;
#pragma warning disable IDE0305
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
        return gameDbContext.PlatformEntities.FirstOrDefault(t => t.Id == id) ?? throw new SqlNullValueException();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.PlatformEntities.Any(t => t.Id == id);
    }

    public bool TypeExists(string type)
    {
        return gameDbContext.PlatformEntities.Any(t => t.Type == type);
    }

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key)
    {
        var entities = gameDbContext.PlatformEntities.Where(p => p.GameEntities.Any(a => a.Key == key)).ToList();

        return entities;
    }

    public bool PlatformNameExistsDb(string platformName)
    {
        var entities = gameDbContext.PlatformEntities.Any(p => p.Type == platformName);

        return entities;
    }
}