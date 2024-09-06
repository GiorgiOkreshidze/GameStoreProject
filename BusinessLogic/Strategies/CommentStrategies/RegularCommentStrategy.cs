using BusinessLogic.ValueObjects;
using DataAccess.Entities;

namespace BusinessLogic.Strategies.CommentStrategies;

public class RegularCommentStrategy : ICommentStrategy
{
    public string CommentType => CommentActionType.Regular;

    public string GetCommentBody(Guid key, IDictionary<Guid, CommentEntity> comments, IEnumerable<ICommentStrategy> commentStrategies)
    {
        var curComment = comments[key];

        return curComment.Deleted ? "A comment/quote was deleted" : curComment.Body;
    }
}