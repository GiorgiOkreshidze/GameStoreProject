using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface ICommentDbService
{
    public ICollection<BanEntity> GetBanDurationsDb();
}