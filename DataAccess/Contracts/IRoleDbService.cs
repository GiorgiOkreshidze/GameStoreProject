using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IRoleDbService
{
    public ICollection<RoleEntity> GetAllRolesDb();

    public RoleEntity GetRoleByIdDb(Guid id);

    public bool DeleteRoleByIdDb(Guid id);

    public ICollection<PermissionEntity> GetAllPermissionsDb();

    public ICollection<PermissionEntity> GetPermissionsByRoleIdDb(Guid id);

    public void AddRoleDb(RoleEntity roleEntity, ICollection<string> permissions);

    public void UpdateRoleDb(RoleEntity roleEntity, ICollection<string> permissions);
}