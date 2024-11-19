using DTOs.RoleDtos;
#pragma warning disable IDE0005
using DTOs.UserDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IUserService
{
    public ICollection<GetUserDto> GetAllUsers();

    public GetUserDto GetUserById(Guid id);

    public bool DeleteUserById(Guid id);

    public bool AddUser(AddUserDto userDto);

    public bool UpdateUser(UpdateUserDto userDto);

    public ICollection<GetRoleDto> GetRolesOfUser(Guid id);

    public bool UserNameNotExists(string name);

    public bool CheckIfHasAccess(AccessDto accessDto);

    public ICollection<GetRoleDto> GetRolesOfUserByName(string name);

    public ICollection<GetPermissionDto> GetPermissionsOfUserByName(string name);

    public bool CheckPassword(LoginDto dto);
}