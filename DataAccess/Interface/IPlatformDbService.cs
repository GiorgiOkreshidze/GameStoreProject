using DataAccess.Entities;

namespace DataAccess.Interface;

public interface IPlatformDbService
{
    public PlatformEntity getPlatformByGuid(Guid guid);
}