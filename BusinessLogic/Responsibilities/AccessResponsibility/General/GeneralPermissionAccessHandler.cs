using System.IdentityModel.Tokens.Jwt;
using BusinessLogic.HelperFunctions;

namespace BusinessLogic.Responsibilities.AccessResponsibility.General;

public class GeneralPermissionAccessHandler : IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token)
    {
        return token.HasPermission(actionType);
    }
}