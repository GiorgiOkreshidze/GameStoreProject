using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.CommentDtos;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class GameProfile : Profile
{
    public GameProfile()
    {
        // GameDtos to GameModels
        CreateMap<GameDto, Game>().ReverseMap();
        CreateMap<CreateGameDto, Game>().IncludeMembers(src => src.Game)
            .ReverseMap();
        CreateMap<GameDtoWithId, Game>().ReverseMap();
        CreateMap<UpdateGameDto, Game>().IncludeMembers(src => src.Game)
            .ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();

        // Models to entities
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<Comment, CommentEntity>().ReverseMap();

        // Other
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<CommentDto, Comment>().ReverseMap();
        CreateMap<AddCommentDto, Comment>().IncludeMembers(src => src.Comment)
            .ReverseMap();
    }
}