using System.Security.Claims;
using BusinessLogic.Validations;

namespace BusinessLogic.Responsibilities.AccessResponsibility.Game;

public class DeleteGameAccessHandler(GameValidator gameValidator) : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
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