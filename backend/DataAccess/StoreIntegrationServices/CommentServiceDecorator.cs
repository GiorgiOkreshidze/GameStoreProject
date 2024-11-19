using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.StoreIntegrationContracts;

namespace DataAccess.StoreIntegrationServices;

public class CommentServiceDecorator(ICommentDbService commentDbService, IGameServiceDecorator gameServiceDecorator) : ICommentDbService
{
    public void BanUserDb(BannedUserEntity bannedUserEntity)
    {
        commentDbService.BanUserDb(bannedUserEntity);
    }

    public void AddCommentDb(string key, CommentEntity commentEntity)
    {
        gameServiceDecorator.TransferGameFromMongoToDb(key);

        commentDbService.AddCommentDb(key, commentEntity);
    }

    public IDictionary<Guid, CommentEntity> GetCommentsDb(string key)
    {
        return commentDbService.GetCommentsDb(key);
    }

    public bool IsUserBanned(string name)
    {
        return commentDbService.IsUserBanned(name);
    }

    public void DeleteCommentDb(string key, Guid id)
    {
        commentDbService.DeleteCommentDb(key, id);
    }

    public CommentEntity GetCommentById(Guid commentId)
    {
        return commentDbService.GetCommentById(commentId);
    }
}