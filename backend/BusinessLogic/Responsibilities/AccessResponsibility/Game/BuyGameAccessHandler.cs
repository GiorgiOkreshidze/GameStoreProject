using System.Security.Claims;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class BuyGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
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