using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Interface;

public class PlatformDbService : IPlatformDbService
{
    private GameDbContext _gameDbContext;
    
    public PlatformDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
    
    public PlatformEntity getPlatformByGuid(Guid guid)
    {
        return _gameDbContext.Set<PlatformEntity>().Where(g => g.Id == guid).FirstOrDefault();;
    }
}