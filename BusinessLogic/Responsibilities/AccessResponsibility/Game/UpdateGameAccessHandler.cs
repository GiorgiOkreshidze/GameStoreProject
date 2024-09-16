using System.Security.Claims;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class UpdateGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
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