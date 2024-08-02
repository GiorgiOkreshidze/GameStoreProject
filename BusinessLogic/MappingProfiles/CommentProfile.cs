using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.CommentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class CommentProfile : Profile
{
    public CommentProfile()
    {
        CreateMap<BannedUserEntity, BannedUser>().ReverseMap();
        CreateMap<BannedUser, BanUserDto>().ReverseMap();
    }
}