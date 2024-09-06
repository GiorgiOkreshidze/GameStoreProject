using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DTOs.UserDtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class UserDbService(GameDbContext gameDbContext) : IUserDbService
{
    public ICollection<UserEntity> GetAllUsersDb()
    {
        return [.. gameDbContext.UserEntities.AsNoTracking()];
    }

    public UserEntity GetUserByIdDb(Guid id)
    {
        return gameDbContext.UserEntities.AsNoTracking().FirstOrDefault(user => user.Id == id);
    }

    public bool DeleteUserByIdDb(Guid id)
    {
        var userEntity = gameDbContext.UserEntities.FirstOrDefault(user => user.Id == id);

        if (userEntity is null)
        {
            return false;
        }

        gameDbContext.UserEntities.Remove(userEntity);
        gameDbContext.SaveChanges();
        return true;
    }

    public bool AddUserDb(UserEntity userEntity)
    {
        gameDbContext.AttachRange(userEntity.Roles);
        gameDbContext.UserEntities.Add(userEntity);
        gameDbContext.SaveChanges();
        return true;
    }

    public bool UpdateUserDb(UserEntity userEntity)
    {
        ClearRolesFromUser(userEntity.Id);
        gameDbContext.AttachRange(userEntity.Roles);
        gameDbContext.UserEntities.Update(userEntity);
        gameDbContext.SaveChanges();
        return true;
    }

    public ICollection<RoleEntity> GetRolesOfUserDb(Guid id)
    {
        return gameDbContext.UserEntities.AsNoTracking()
            .Include(user => user.Roles)
            .FirstOrDefault(user => user.Id == id).Roles;
    }

    public bool UserNameNotExistsDb(string name)
    {
        return !gameDbContext.UserEntities.AsNoTracking().Any(u => u.Name == name);
    }

    // not Complete
    public bool CheckIfHasAccessDb(AccessDto accessDto)
    {
        /*if (accessDto.TargetPage == "Genres")
        {
            var genre = gameDbContext.GenreEntities.AsNoTracking().FirstOrDefault(genre => genre.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Games")
        {
            var game = gameDbContext.GameEntities.AsNoTracking().FirstOrDefault(game => game.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Platforms")
        {
            var genre = gameDbContext.PlatformEntities.AsNoTracking().FirstOrDefault(platform => platform.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Publishers")
        {
            var game = gameDbContext.PublisherEntities.AsNoTracking().FirstOrDefault(publisher => publisher.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Orders")
        {
            var genre = gameDbContext.OrderEntities.AsNoTracking().FirstOrDefault(order => order.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Users")
        {
            var user = gameDbContext.UserEntities.AsNoTracking().FirstOrDefault(user => user.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "Roles")
        {
            var role = gameDbContext.RoleEntities.AsNoTracking().FirstOrDefault(role => role.Id == accessDto.TargetId);
            return true;
        }

        if (accessDto.TargetPage == "History")
        {
            var order = gameDbContext.OrderEntities.AsNoTracking().FirstOrDefault(order => order.Id == accessDto.TargetId);
            return true;
        }

        return false;*/
        /*var roles = gameDbContext.UserEntities.AsNoTracking()
            .Include(userEntity => userEntity.Roles)
            .ThenInclude(roleEntity => roleEntity.Permissions)
            .FirstOrDefault(u => u.Id == accessDto.TargetId).Roles;
        foreach (var role in roles)
        {
            hasPermission = role.Permissions.Any(p => p.Name == accessDto.TargetPage);
            if (hasPermission)
            {
                return hasPermission;
            }
        }

        return hasPermission;*/

        return true;
    }

    public ICollection<RoleEntity> GetRolesOfUserByNameDb(string name)
    {
        return gameDbContext.UserEntities.AsNoTracking()
            .Include(user => user.Roles)
            .FirstOrDefault(user => user.Name == name).Roles;
    }

    public ICollection<PermissionEntity> GetPermissionsOfUserByNameDb(string name)
    {
        List<PermissionEntity> permissionEntities = [];
        var roles = gameDbContext.UserEntities
            .AsNoTracking()
            .Include(user => user.Roles)
            .ThenInclude(roleEntity => roleEntity.Permissions)
            .FirstOrDefault(user => user.Name == name).Roles;

        foreach (var role in roles)
        {
            permissionEntities.AddRange(role.Permissions);
        }

        return permissionEntities;
    }

    public bool UserCanPerformAction(string userName, string permissionName)
    {
        return gameDbContext.PermissionEntities.Any(p => p.Name == userName
                                                         && p.Roles.Any(r => r.Permissions.Any(pp => p.Name == permissionName)));
    }

    public UserEntity GetUserByNameDb(string targetUser)
    {
        return gameDbContext.UserEntities.FirstOrDefault(u => u.Name == targetUser);
    }

    private void ClearRolesFromUser(Guid id)
    {
        var userRoles = gameDbContext.UserRoles.Where(userRole => userRole.UserEntityId == id).ToList();

        foreach (var userRole in userRoles)
        {
            gameDbContext.Remove(userRole);
        }

        gameDbContext.SaveChanges();
    }
}