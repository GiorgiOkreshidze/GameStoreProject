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

        CreateMap<Comment, CommentEntity>().ReverseMap();
        CreateMap<CommentDto, Comment>().ReverseMap();
        CreateMap<AddCommentDto, Comment>().IncludeMembers(src => src.Comment)
            .ForMember(dest => dest.ParentCommentId, opt => opt.MapFrom(src => src.ParentId))
            .ReverseMap()
            .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentCommentId));
    }
}