using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
#pragma warning disable IDE0005
using DTOs.RoleDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        // entities to models
        CreateMap<RoleEntity, Role>().ReverseMap();
        CreateMap<PermissionEntity, PermissionModel>().ReverseMap();

        // models to dtos
        CreateMap<Role, GetRoleDto>().ReverseMap();
        CreateMap<AddRoleDto, Role>().IncludeMembers(src => src.Role).ReverseMap();
        CreateMap<RoleDto, Role>().ReverseMap();
        CreateMap<RoleDtoWithId, Role>().ReverseMap();
        CreateMap<UpdateRoleDto, Role>().IncludeMembers(src => src.Role).ReverseMap();
        CreateMap<PermissionModel, GetPermissionDto>().ReverseMap();
    }
}