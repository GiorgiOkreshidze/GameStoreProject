using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PlatformDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class PlatformProfile : Profile
{
    public PlatformProfile()
    {
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<Platform, GetPlatformDto>().ReverseMap();
        CreateMap<Platform, CreatePlatformDto>().ReverseMap();
        CreateMap<PlatformDtoWithoutId, Platform>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
        CreateMap<Platform, UpdatePlatformDto>().ReverseMap();
    }
}