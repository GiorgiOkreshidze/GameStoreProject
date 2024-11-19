using DataAccess.Contracts;
using DataAccess.Entities;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class PlatformDbServiceLoggingDecorator(IPlatformDbService platformDbService, IChangeLogMongoService logMongoService) : IPlatformDbService
{
    private const string EntityName = "Platform";

    public void CreatePlatformDb(PlatformEntity platformEntity)
    {
        platformDbService.CreatePlatformDb(platformEntity);
        logMongoService.LogChange(EntityName, "Add Platform", null, platformEntity);
    }

    public ICollection<PlatformEntity> GetAllPlatformsDb()
    {
        return platformDbService.GetAllPlatformsDb();
    }

    public void UpdatePlatformDb(PlatformEntity platformEntity)
    {
        var oldPlatform = platformDbService.GetPlatformByGuid(platformEntity.Id);
        platformDbService.UpdatePlatformDb(platformEntity);
        logMongoService.LogChange(EntityName, "Update Platform", oldPlatform, platformEntity);
    }

    public void DeletePlatformDb(PlatformEntity platformEntity)
    {
        platformDbService.DeletePlatformDb(platformEntity);
        logMongoService.LogChange(EntityName, "Delete Platform", platformEntity, null);
    }

    public PlatformEntity GetPlatformByGuid(Guid id)
    {
        return platformDbService.GetPlatformByGuid(id);
    }

    public bool NotExists(Guid id)
    {
        return platformDbService.NotExists(id);
    }

    public bool TypeExists(string type)
    {
        return platformDbService.TypeExists(type);
    }

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key)
    {
        return platformDbService.GetPlatformsOfGameDb(key);
    }

    public bool PlatformNameExistsDb(string platformName)
    {
        return platformDbService.PlatformNameExistsDb(platformName);
    }
}