using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Services;

public class CommentDbService(GameDbContext gameDbContext) : ICommentDbService
{
    public void BanUserDb(BannedUserEntity bannedUserEntity)
    {
        var nameExists = gameDbContext.CommentEntities.Any(c => c.Name == bannedUserEntity.User);

        if (nameExists)
        {
            gameDbContext.BannedUserEntities.Add(bannedUserEntity);
            gameDbContext.SaveChanges();
        }
        else
        {
            throw new Exception("Name Doesn't exists");
        }
    }
}