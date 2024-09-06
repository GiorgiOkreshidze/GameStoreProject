using System.IdentityModel.Tokens.Jwt;

namespace BusinessLogic.Responsibilities.AccessResponsibility;

public interface IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, JwtSecurityToken token);
}