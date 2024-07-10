using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;

namespace BusinessLogic.MappingProfiles;

public class PublisherProfile : Profile
{
    public PublisherProfile()
    {
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<PublisherEntity, Publisher>().ReverseMap();
        CreateMap<Publisher, CreatePublisherDto>().ReverseMap();
        CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        CreateMap<Publisher, UpdatePublisherDto>().ReverseMap();
    }
}