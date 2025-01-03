using BusinessLogic.Contracts;
using BusinessLogic.Responsibilities.AccessResponsibility;
using DTOs.UserDtos;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Services;

public class AccessService(IEnumerable<IAccessHandler> accessHandlers,
    IHttpContextAccessor httpContextAccessor) : IAccessService
{
    public bool HasAccess(AccessDto accessDto)
    {
        var claims = httpContextAccessor.HttpContext.User.Claims;
        /*var tokenString = httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();
        tokenString = tokenString.Replace("bearer ", string.Empty);
        var token = new JwtSecurityTokenHandler().ReadJwtToken(tokenString);*/
        foreach (var accessHandler in accessHandlers)
        {
            if (!accessHandler.HasAccess(accessDto.TargetPage, accessDto.TargetId, claims))
            {
                return false;
            }
        }

        return true;
    }
}