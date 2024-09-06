using AutoMapper;
using BusinessLogic.Models;
using DTOs.RoleDtos;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.UserDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        // entities to models
        CreateMap<UserEntity, User>()
            .ForMember(dest => dest.Roles, opt => opt.Ignore())
            .ReverseMap()
            .ForMember(dest => dest.Roles, opt => opt.Ignore());
        CreateMap<RoleEntity, Role>().ReverseMap();

        // models to dtos
        CreateMap<User, GetUserDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserDtoWithId>().ReverseMap();
        CreateMap<User, AddUserDto>()
            .ReverseMap().IncludeMembers(src => src.User);
        CreateMap<User, UpdateUserDto>()
            .ReverseMap().IncludeMembers(src => src.User);
        CreateMap<Role, GetRoleDto>().ReverseMap();
    }
}