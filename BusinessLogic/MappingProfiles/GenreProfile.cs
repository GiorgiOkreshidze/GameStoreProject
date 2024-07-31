using AutoMapper;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.MappingProfiles;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        // GenreDtos to GenreModels
        CreateMap<CreateGenreDto, Genre>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name))
            .ForMember(dest => dest.ParentGenreId, opt => opt.MapFrom(src => src.Genre.ParentGenreId))
            .ReverseMap();
        CreateMap<UpdateGenreDto, Genre>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Genre.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name))
            .ReverseMap();
        CreateMap<GenreDtoWithParentId, Genre>().ReverseMap();
        CreateMap<Genre, GetGenreDto>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();

        // Models to entities
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
    }
}