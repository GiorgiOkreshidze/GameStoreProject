using System.Diagnostics.CodeAnalysis;
using BusinessLogic.HelperFunctions;
using DataAccess.Contracts;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Validations;

#pragma warning disable SA1404
[SuppressMessage("Style", "IDE0270:Use coalesce expression")]
#pragma warning restore SA1404

public class CommentValidator(IHttpContextAccessor httpContextAccessor,
    ICommentDbService commentDbService,
    IGameDbService gameDbService,
    IUserDbService userDbService) : Validator(httpContextAccessor)
{
    public void CanDeleteComment(Guid commentId)
    {
        if (commentId == Guid.Empty)
        {
            throw new ArgumentNullException("Comment id is not specified");
        }

        CommentEntity comment = commentDbService.GetCommentById(commentId);

        if (comment == null)
        {
            throw new ArgumentException("Comment with given ID does not exist");
        }

        if (!(_token.GetUserName() == comment.Name || _token.HasPermission("ManageAllComments")))
        {
            throw new UnauthorizedAccessException("You can't delete other user's comments");
        }

        if (comment.Deleted)
        {
            throw new UnauthorizedAccessException("You can't delete deleted comment");
        }
    }

    public void CanAddComment(string key)
    {
        if (commentDbService.IsUserBanned(_token.GetUserName()))
        {
            throw new UnauthorizedAccessException("You are banned!");
        }

        var game = gameDbService.GetGameByKeyDb(key);

        if (game == null)
        {
            throw new InvalidDataException("Game does not exist on given key");
        }

        if (game.Deleted)
        {
            throw new InvalidOperationException("Game is deleted");
        }
    }

    public void CanBanUser(string targetUser)
    {
        UserEntity user = userDbService.GetUserByNameDb(targetUser);

        if (user == null)
        {
            throw new InvalidDataException("User does not exist");
        }
    }
}