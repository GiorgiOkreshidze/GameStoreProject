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
        CreateMap<BanEntity, BanModel>().ReverseMap();
        CreateMap<BanModel, BanDurationDto>().ReverseMap();
    }
}