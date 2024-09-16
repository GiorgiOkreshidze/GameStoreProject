using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DTOs.RoleDtos;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.UserDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class UserService(IUserDbService userDbService, IMapper userMapper) : IUserService
{
    public ICollection<GetUserDto> GetAllUsers()
    {
        var userEntities = userDbService.GetAllUsersDb();

        var users = userMapper.Map<ICollection<UserEntity>, ICollection<User>>(userEntities);
        var userDtos = userMapper.Map<ICollection<User>, ICollection<GetUserDto>>(users);

        return userDtos;
    }

    public GetUserDto GetUserById(Guid id)
    {
        var userEntity = userDbService.GetUserByIdDb(id);

        var user = userMapper.Map<UserEntity, User>(userEntity);
        var userDto = userMapper.Map<User, GetUserDto>(user);

        return userDto;
    }

    public bool DeleteUserById(Guid id)
    {
        return userDbService.DeleteUserByIdDb(id);
    }

    public bool AddUser(AddUserDto userDto)
    {
        var user = userMapper.Map<AddUserDto, User>(userDto);
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
        var userEntity = userMapper.Map<User, UserEntity>(user);

        userEntity.Id = Guid.NewGuid();
        userEntity.Roles = [];
        foreach (var roleId in user.Roles)
        {
            var stubRole = new RoleEntity()
            {
                Id = roleId,
            };

            userEntity.Roles.Add(stubRole);
        }

        return userDbService.AddUserDb(userEntity);
    }

    public bool UpdateUser(UpdateUserDto userDto)
    {
        var user = userMapper.Map<UpdateUserDto, User>(userDto);
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
        var userEntity = userMapper.Map<User, UserEntity>(user);

        userEntity.Roles = [];
        foreach (var roleId in user.Roles)
        {
            var stubRole = new RoleEntity()
            {
                Id = roleId,
            };

            userEntity.Roles.Add(stubRole);
        }

        return userDbService.UpdateUserDb(userEntity);
    }

    public ICollection<GetRoleDto> GetRolesOfUser(Guid id)
    {
        var roleEntities = userDbService.GetRolesOfUserDb(id);

        var roles = userMapper.Map<ICollection<RoleEntity>, ICollection<Role>>(roleEntities);
        var roleDtos = userMapper.Map<ICollection<Role>, ICollection<GetRoleDto>>(roles);

        return roleDtos;
    }

    public bool UserNameNotExists(string name)
    {
        return userDbService.UserNameNotExistsDb(name);
    }

    public bool CheckIfHasAccess(AccessDto accessDto)
    {
        return userDbService.CheckIfHasAccessDb(accessDto);
    }

    public ICollection<GetRoleDto> GetRolesOfUserByName(string name)
    {
        var roleEntities = userDbService.GetRolesOfUserByNameDb(name);

        var roles = userMapper.Map<ICollection<RoleEntity>, ICollection<Role>>(roleEntities);
        var roleDtos = userMapper.Map<ICollection<Role>, ICollection<GetRoleDto>>(roles);

        return roleDtos;
    }

    public ICollection<GetPermissionDto> GetPermissionsOfUserByName(string name)
    {
        var permissionsEntities = userDbService.GetPermissionsOfUserByNameDb(name);

        var permissions =
            userMapper.Map<ICollection<PermissionEntity>, ICollection<PermissionModel>>(permissionsEntities);
        var permissionDtos = userMapper.Map<ICollection<PermissionModel>, ICollection<GetPermissionDto>>(permissions);

        return permissionDtos;
    }

    public bool CheckPassword(LoginDto dto)
    {
        var user = userDbService.GetUserByNameDb(dto.Model.Login);
        return BCrypt.Net.BCrypt.Verify(dto.Model.Password, user.PasswordHash);
    }
}