#pragma warning disable IDE0005
using DTOs.RoleDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IRoleService
{
    public ICollection<GetRoleDto> GetAllRoles();

    public GetRoleDto GetRoleById(Guid id);

    public bool DeleteRoleById(Guid id);

    public ICollection<string> GetAllPermissions();

    public ICollection<string> GetPermissionsByRoleId(Guid id);

    public void AddRole(AddRoleDto roleDto);

    public void UpdateRole(UpdateRoleDto roleDto);
}