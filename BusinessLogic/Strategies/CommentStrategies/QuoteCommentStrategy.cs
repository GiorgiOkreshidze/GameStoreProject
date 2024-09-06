using System.Text;
using BusinessLogic.ValueObjects;
using DataAccess.Entities;

namespace BusinessLogic.Strategies.CommentStrategies;

public class QuoteCommentStrategy : ICommentStrategy
{
    public string CommentType => CommentActionType.Quote;

    public string GetCommentBody(Guid key, IDictionary<Guid, CommentEntity> comments, IEnumerable<ICommentStrategy> commentStrategies)
    {
        StringBuilder stringBuilder = new();
        var curComment = comments[key];

        if (curComment.Deleted)
        {
            return "A comment/quote was deleted";
        }

        CommentEntity nextComment;

        do
        {
            nextComment = comments[(Guid)curComment.ParentCommentId!];

            if (curComment.Deleted)
            {
                stringBuilder.Insert(0, "A comment/quote was deleted");
                stringBuilder.Insert(0, ", ");
            }
            else
            {
                stringBuilder.Insert(0, curComment.Body);
                stringBuilder.Insert(0, ", ");
            }

            curComment = nextComment;
        }
        while (nextComment.Action == CommentType);

        stringBuilder.Insert(0, ICommentStrategy.GetCommentStrategy(commentStrategies, nextComment.Action).GetCommentBody(nextComment.Id, comments, commentStrategies));

        return stringBuilder.ToString();
    }
}