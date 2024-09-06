using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class DeleteGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
    {
        if (actionType == "DeleteGame")
        {
            try
            {
                gameValidator.DeleteGame(objectIdentifier);
            }
            catch (Exception)
            {
                return false;
            }
        }

        return true;
    }
}