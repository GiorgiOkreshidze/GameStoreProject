using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Validations;

#pragma warning disable SA1401
#pragma warning disable CA1051

public class Validator(IHttpContextAccessor httpContextAccessor)
{
    protected readonly IEnumerable<Claim> _claims = httpContextAccessor.HttpContext.User.Claims;
}