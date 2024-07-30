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
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<GameDto, Game>().ReverseMap();
        CreateMap<Game, UpdateGameDto>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<GameDtoWithId, Game>().ReverseMap();
        CreateMap<AddCommentDto, Comment>().ReverseMap();
        CreateMap<Comment, CommentEntity>().ReverseMap();
    }
}