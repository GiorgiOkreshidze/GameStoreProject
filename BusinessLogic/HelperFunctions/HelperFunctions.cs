using System.Security.Claims;

namespace BusinessLogic.HelperFunctions;

public static class HelperFunctions
{
    public static bool HasPermission(this IEnumerable<Claim> claims, string permission)
    {
        return claims.Any(claim => claim.Type == "Permission" && claim.Value == permission);
    }

    public static string GetUserName(this IEnumerable<Claim> claims)
    {
        var nameClaim = claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Name);
        return nameClaim?.Value;
    }
}