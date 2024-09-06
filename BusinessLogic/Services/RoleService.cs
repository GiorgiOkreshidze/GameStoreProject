using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Entities;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DTOs.RoleDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class RoleService(IRoleDbService roleDbService, IMapper roleMapper) : IRoleService
{
    public ICollection<GetRoleDto> GetAllRoles()
    {
        var roleEntities = roleDbService.GetAllRolesDb();

        var roles = roleMapper.Map<ICollection<RoleEntity>, ICollection<Role>>(roleEntities);
        var roleDtos = roleMapper.Map<ICollection<Role>, ICollection<GetRoleDto>>(roles);

        return roleDtos;
    }

    public GetRoleDto GetRoleById(Guid id)
    {
        var roleEntity = roleDbService.GetRoleByIdDb(id);

        var role = roleMapper.Map<RoleEntity, Role>(roleEntity);
        var roleDto = roleMapper.Map<Role, GetRoleDto>(role);

        return roleDto;
    }

    public bool DeleteRoleById(Guid id)
    {
        try
        {
            return roleDbService.DeleteRoleByIdDb(id);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("An error occurred while deleting the user.", ex);
        }
    }

    public ICollection<string> GetAllPermissions()
    {
        var permissionEntities = roleDbService.GetAllPermissionsDb();

        List<string> permissionNames = [];

        foreach (var permissionEntity in permissionEntities)
        {
            permissionNames.Add(permissionEntity.Name);
        }

        return permissionNames;
    }

    public ICollection<string> GetPermissionsByRoleId(Guid id)
    {
        var permissionEntities = roleDbService.GetPermissionsByRoleIdDb(id);

        List<string> permissionNames = [];

        foreach (var permissionEntity in permissionEntities)
        {
            permissionNames.Add(permissionEntity.Name);
        }

        return permissionNames;
    }

    public void AddRole(AddRoleDto roleDto)
    {
        var role = roleMapper.Map<AddRoleDto, Role>(roleDto);
        var roleEntity = roleMapper.Map<Role, RoleEntity>(role);

        roleEntity.Id = Guid.NewGuid();

        roleDbService.AddRoleDb(roleEntity, roleDto.Permissions);
    }

    public void UpdateRole(UpdateRoleDto roleDto)
    {
        var role = roleMapper.Map<UpdateRoleDto, Role>(roleDto);
        var roleEntity = roleMapper.Map<Role, RoleEntity>(role);

        roleDbService.UpdateRoleDb(roleEntity, roleDto.Permissions);
    }
}