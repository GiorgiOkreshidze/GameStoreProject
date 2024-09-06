using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace BusinessLogic.HelperFunctions;

public static class HelperFunctions
{
    public static bool HasPermission(this JwtSecurityToken token, string permission)
    {
        return token.Claims
            .Any(claim => claim.Type == "Permission" && claim.Value == permission);
    }

    public static string GetUserName(this JwtSecurityToken token)
    {
        var nameClaim = token.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Name);
        return nameClaim?.Value;
    }
}