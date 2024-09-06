using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Comment;

public class AddCommentAccessHandler(CommentValidator commentValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
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