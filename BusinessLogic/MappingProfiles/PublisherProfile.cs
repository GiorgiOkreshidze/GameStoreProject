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
        CreateMap<PublisherDto, Publisher>().ReverseMap();
        CreateMap<CreatePublisherDto, Publisher>().IncludeMembers(src => src.Publisher)
            .ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<Publisher, UpdatePublisherDto>().ReverseMap();

        // Models to Entities
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<GameEntity, Game>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
    }
}