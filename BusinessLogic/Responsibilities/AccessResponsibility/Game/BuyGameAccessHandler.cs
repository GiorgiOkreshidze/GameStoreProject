using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class BuyGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
    {
        if (actionType == "Buy")
        {
            try
            {
                gameValidator.CanBuyGame(objectIdentifier);
            }
            catch (Exception)
            {
                return false;
            }
        }

        return true;
    }
}