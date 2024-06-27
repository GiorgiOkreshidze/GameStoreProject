using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;

namespace BusinessLogic.MappingProfiles;

public class GenreProfile : Profile
{
    public GenreProfile()
    {
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<Genre, CreateGenreDto>().ReverseMap();
        CreateMap<Genre, GetGenreDto>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<UpdateGenreDto, Genre>().ReverseMap();
    }
}