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
        CreateMap<CreatePlatformDto, Platform>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Platform.Type))
            .ReverseMap();
        CreateMap<UpdatePlatformDto, Platform>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Platform.Id))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Platform.Type)).ReverseMap();
        CreateMap<Platform, GetPlatformDto>().ReverseMap();
        CreateMap<PlatformDtoWithoutId, Platform>().ReverseMap();
        CreateMap<Platform, PlatformDto>().ReverseMap();

        // Models to Entities
        CreateMap<PlatformEntity, Platform>().ReverseMap();
        CreateMap<GameEntity, Game>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
    }
}