using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace DataAccess.Services;

public class RoleDbService(GameDbContext gameDbContext, IMemoryCache cache) : IRoleDbService
{
    public ICollection<RoleEntity> GetAllRolesDb()
    {
        return [.. gameDbContext.RoleEntities.AsNoTracking()];
    }

    public RoleEntity GetRoleByIdDb(Guid id)
    {
        return gameDbContext.RoleEntities.AsNoTracking().FirstOrDefault(role => role.Id == id);
    }

    public bool DeleteRoleByIdDb(Guid id)
    {
        var roleEntity = gameDbContext.RoleEntities.FirstOrDefault(role => role.Id == id);

        if (roleEntity is null)
        {
            return false;
        }

        gameDbContext.RoleEntities.Remove(roleEntity);
        gameDbContext.SaveChanges();
        return true;
    }

    public ICollection<PermissionEntity> GetAllPermissionsDb()
    {
        return [.. gameDbContext.PermissionEntities.AsNoTracking()];
    }

    public ICollection<PermissionEntity> GetPermissionsByRoleIdDb(Guid id)
    {
        return gameDbContext.RoleEntities.AsNoTracking().Include(roleEntity => roleEntity.Permissions)
            .FirstOrDefault(r => r.Id == id).Permissions;
    }

    public void AddRoleDb(RoleEntity roleEntity, ICollection<string> permissions)
    {
        roleEntity.Permissions = [];
        foreach (var permission in permissions)
        {
            var entity = gameDbContext.PermissionEntities.AsNoTracking().FirstOrDefault(p => p.Name == permission) ?? throw new InvalidOperationException();

            roleEntity.Permissions.Add(entity);
        }

        gameDbContext.AttachRange(roleEntity.Permissions);
        gameDbContext.RoleEntities.Add(roleEntity);
        gameDbContext.SaveChanges();
    }

    public void UpdateRoleDb(RoleEntity roleEntity, ICollection<string> permissions)
    {
        roleEntity.Permissions = [];
        foreach (var permission in permissions)
        {
            var entity = gameDbContext.PermissionEntities.AsNoTracking().FirstOrDefault(p => p.Name == permission) ?? throw new InvalidOperationException();

            roleEntity.Permissions.Add(entity);
        }

        ClearPermissionsFromRole(roleEntity.Id);
        gameDbContext.AttachRange(roleEntity.Permissions);
        gameDbContext.RoleEntities.Update(roleEntity);
        gameDbContext.SaveChanges();
    }

    public ICollection<PermissionEntity> GetGuestPermissionEntities()
    {
        if (!cache.TryGetValue("GuestPermissions", out ICollection<PermissionEntity> guestPermissions))
        {
            guestPermissions = [.. gameDbContext.PermissionEntities.AsNoTracking().Where(p => p.AllowedOnGuest)];
            cache.Set("GuestPermissions", guestPermissions, TimeSpan.FromHours(1));
        }

        return guestPermissions;
    }

    private void ClearPermissionsFromRole(Guid id)
    {
        var permissionRoles = gameDbContext.PermissionRoles.Where(p => p.RoleEntityId == id).ToList();

        foreach (var permissionRole in permissionRoles)
        {
            gameDbContext.Remove(permissionRole);
        }

        gameDbContext.SaveChanges();
    }
}