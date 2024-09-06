using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class UpdateGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
    {
        if (actionType == "UpdateGame")
        {
            try
            {
                gameValidator.UpdateGame(objectIdentifier);
            }
            catch (Exception)
            {
                return false;
            }
        }

        return true;
    }
}