using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface ICommentDbService
{
    public void BanUserDb(BannedUserEntity bannedUserEntity);

    public void AddCommentDb(string key, CommentEntity commentEntity);

    public IDictionary<Guid, CommentEntity> GetCommentsDb(string key);

    public bool IsUserBanned(string name);

    public void DeleteCommentDb(string key, Guid id);

    CommentEntity GetCommentById(Guid commentId);
}