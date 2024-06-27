using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IPlatformDbService
{
    public void CreatePlatformDb(PlatformEntity platformEntity);

    public ICollection<PlatformEntity> GetAllPlatformsDb();

    public void UpdatePlatformDb(PlatformEntity platformEntity);

    public void DeletePlatformDb(Guid id);
    public PlatformEntity GetPlatformByGuid(Guid guid);

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id);
}