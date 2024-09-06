using DTOs.UserDtos;

namespace BusinessLogic.Contracts;

public interface IAccessService
{
    public bool HasAccess(AccessDto accessDto);
}