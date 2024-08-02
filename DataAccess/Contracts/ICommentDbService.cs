using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface ICommentDbService
{
    public void BanUserDb(BannedUserEntity bannedUserEntity);
}