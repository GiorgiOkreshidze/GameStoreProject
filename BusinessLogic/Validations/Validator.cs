using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace BusinessLogic.Validations;

#pragma warning disable SA1401
#pragma warning disable CA1051

public class Validator
{
    // ReSharper disable once InconsistentNaming
    protected readonly JwtSecurityToken _token;

    public Validator(IHttpContextAccessor httpContextAccessor)
    {
        var token = httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();
        if (token.IsNullOrEmpty())
        {
            return;
        }

        token = token.Replace("bearer ", string.Empty);
        _token = new JwtSecurityTokenHandler().ReadJwtToken(token);
    }
}