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
        CreateMap<GenreDtoWithParentId, Genre>().ReverseMap();
        CreateMap<CreateGenreDto, Genre>().IncludeMembers(src => src.Genre)
            .ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<UpdateGenreDto, Genre>().IncludeMembers(src => src.Genre)
            .ReverseMap();
        CreateMap<Genre, GetGenreDto>().ReverseMap();

        // Models to entities
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();

        // Other
        CreateMap<Game, GetGameDto>().ReverseMap();
    }
}