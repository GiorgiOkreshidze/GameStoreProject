using System.Security.Claims;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Comment;

public class DeleteCommentAccessHandler(CommentValidator commentValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
    {
        if (actionType == "DeleteComment")
        {
            try
            {
                commentValidator.CanDeleteComment(new Guid(objectIdentifier));
            }
            catch (Exception)
            {
                return false;
            }
        }

        return true;
    }
}