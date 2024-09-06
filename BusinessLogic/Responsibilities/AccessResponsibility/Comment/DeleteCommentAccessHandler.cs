using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Comment;

public class DeleteCommentAccessHandler(CommentValidator commentValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
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