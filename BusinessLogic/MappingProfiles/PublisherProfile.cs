using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        // PublisherDtos to PublisherModels
        CreateMap<CreatePublisherDto, Publisher>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.Publisher.CompanyName))
            .ForMember(dest => dest.HomePage, opt => opt.MapFrom(src => src.Publisher.HomePage))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Publisher.Description))
            .ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<Publisher, UpdatePublisherDto>().ReverseMap();
        CreateMap<PublisherDto, Publisher>().ReverseMap();

        // Models to Entities
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<GameEntity, Game>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
    }
}