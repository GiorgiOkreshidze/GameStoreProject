using System.Security.Claims;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Comment;

public class AddCommentAccessHandler(CommentValidator commentValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
    {
        if (actionType == "AddComment")
        {
            try
            {
                commentValidator.CanAddComment(objectIdentifier);
            }
            catch (Exception)
            {
                return false;
            }
        }

        return true;
    }
}