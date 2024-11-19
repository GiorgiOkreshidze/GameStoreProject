using BusinessLogic.ValueObjects;
using DataAccess.Entities;

namespace BusinessLogic.Strategies.CommentStrategies;

public class ReplyCommentStrategy : ICommentStrategy
{
    public string CommentType => CommentActionType.Reply;

    public string GetCommentBody(Guid key, IDictionary<Guid, CommentEntity> comments, IEnumerable<ICommentStrategy> commentStrategies)
    {
        var curComment = comments[key];
        var parentId = (Guid)comments[key].ParentCommentId!;
        return curComment.Deleted ? "A comment/quote was deleted" : $"{comments[parentId].Name}, {comments[key].Body}";
    }
}