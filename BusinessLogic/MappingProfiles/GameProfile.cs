using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.MappingProfiles;

public class GameProfile : Profile
{
    public GameProfile()
    {   
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<Game, UpdateGameDto>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
    }
}