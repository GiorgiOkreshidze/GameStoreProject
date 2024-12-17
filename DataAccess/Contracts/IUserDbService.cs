using System.Collections;
using DataAccess.Entities;
using DTOs.UserDtos;

namespace DataAccess.Contracts;

public interface IUserDbService
{
    public ICollection<UserEntity> GetAllUsersDb();

    public UserEntity GetUserByIdDb(Guid id);

    public bool DeleteUserByIdDb(Guid id);

    public bool AddUserDb(UserEntity userEntity);

    public bool UpdateUserDb(UserEntity userEntity);

    public ICollection<RoleEntity> GetRolesOfUserDb(Guid id);

    public bool UserNameNotExistsDb(string name);

    public bool CheckIfHasAccessDb(AccessDto accessDto);

    public ICollection<RoleEntity> GetRolesOfUserByNameDb(string name);

    public ICollection<PermissionEntity> GetPermissionsOfUserByNameDb(string name);

    bool UserCanPerformAction(string userName, string permissionName);

    UserEntity GetUserByNameDb(string targetUser);

    public Task<ICollection<string>> GetManagerAndAdminEmailsAsync();

    public Task<string> GetUserEmailAsync(Guid id);
}