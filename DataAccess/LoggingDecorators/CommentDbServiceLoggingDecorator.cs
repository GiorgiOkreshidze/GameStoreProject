using DataAccess.Contracts;
using DataAccess.Entities;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class CommentDbServiceLoggingDecorator(ICommentDbService commentDbService, IChangeLogMongoService logMongoService) : ICommentDbService
{
    private const string EntityName = "Comment";

    public void BanUserDb(BannedUserEntity bannedUserEntity)
    {
        commentDbService.BanUserDb(bannedUserEntity);
        logMongoService.LogChange(EntityName, "User Banned", null, bannedUserEntity);
    }

    public void AddCommentDb(string key, CommentEntity commentEntity)
    {
        commentDbService.AddCommentDb(key, commentEntity);
        logMongoService.LogChange(EntityName, "Add Comment", null, commentEntity);
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
        var commentEntity = commentDbService.GetCommentById(id);
        commentDbService.DeleteCommentDb(key, id);
        logMongoService.LogChange(EntityName, "Delete Comment", commentEntity, null);
    }

    public CommentEntity GetCommentById(Guid commentId)
    {
        return commentDbService.GetCommentById(commentId);
    }
}