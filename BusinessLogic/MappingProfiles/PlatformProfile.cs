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
        // PlatformDtos to PlatformModels
        CreateMap<PlatformDtoWithoutId, Platform>().ReverseMap();
        CreateMap<CreatePlatformDto, Platform>().IncludeMembers(src => src.Platform)
            .ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();
        CreateMap<UpdatePlatformDto, Platform>().IncludeMembers(src => src.Platform)
            .ReverseMap();
        CreateMap<Platform, GetPlatformDto>().ReverseMap();

        // Models to Entities
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<GameEntity, Game>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
    }
}