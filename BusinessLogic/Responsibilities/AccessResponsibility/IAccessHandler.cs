using System.Security.Claims;

namespace BusinessLogic.Responsibilities.AccessResponsibility;

public interface IAccessHandler
{
    public bool HasAccess(string actionType, string objectIdentifier, IEnumerable<Claim> claims);
}