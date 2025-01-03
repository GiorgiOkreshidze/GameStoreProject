using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IPlatformDbService
{
    public void CreatePlatformDb(PlatformEntity platformEntity);

    public ICollection<PlatformEntity> GetAllPlatformsDb();

    public void UpdatePlatformDb(PlatformEntity platformEntity);

    public void DeletePlatformDb(PlatformEntity platformEntity);

    public PlatformEntity GetPlatformByGuid(Guid id);

    public bool NotExists(Guid id);

    public bool TypeExists(string type);

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key);

    public bool PlatformNameExistsDb(string platformName);
}