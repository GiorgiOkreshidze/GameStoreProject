using DataAccess.Entities;

namespace BusinessLogic.Strategies.CommentStrategies;

public interface ICommentStrategy
{
    public string CommentType { get; }

    public string GetCommentBody(Guid key, IDictionary<Guid, CommentEntity> comments, IEnumerable<ICommentStrategy> commentStrategies);

    public static ICommentStrategy GetCommentStrategy(IEnumerable<ICommentStrategy> strategies, string commentType)
    {
        foreach (var strategy in strategies)
        {
            if (strategy.CommentType == commentType)
            {
                return strategy;
            }
        }

        throw new Exception("Comment Type is wrong");
    }
}