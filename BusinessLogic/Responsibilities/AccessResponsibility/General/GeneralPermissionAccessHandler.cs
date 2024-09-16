using System.Security.Claims;
using BusinessLogic.HelperFunctions;

namespace BusinessLogic.Responsibilities.AccessResponsibility.General;

public class GeneralPermissionAccessHandler : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims)
    {
        return claims.HasPermission(actionType);
    }
}