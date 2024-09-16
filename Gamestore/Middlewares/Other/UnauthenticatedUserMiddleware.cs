using System.Security.Claims;
using DataAccess.Contracts;
using Microsoft.IdentityModel.Tokens;

namespace Gamestore.Middlewares.Other;

public class UnauthenticatedUserMiddleware(IRoleDbService roleDbService) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (context.User.Claims.IsNullOrEmpty())
        {
            var guestPermissionEntities = roleDbService.GetGuestPermissionEntities();

            List<Claim> claims = [];
            claims.AddRange(guestPermissionEntities.Select(permissionEntity => new Claim("Permission", permissionEntity.Name)));

            var identity = new ClaimsIdentity(claims, "Guest");
            context.User = new ClaimsPrincipal(identity);
        }

        await next(context);
    }
}