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
        CreateMap<GameEntity, Game>().ReverseMap();
        CreateMap<Game, GetGameDto>().ReverseMap();
        CreateMap<Game, CreateGameDto>().ReverseMap();
        CreateMap<GenreEntity, Genre>().ReverseMap();
        CreateMap<Genre, CreateGenreDto>().ReverseMap();
        CreateMap<GenreDtoWithParentId, Genre>().ReverseMap();
        CreateMap<Genre, GetGenreDto>().ReverseMap();
        CreateMap<Genre, GenreDto>().ReverseMap();
        CreateMap<UpdateGenreDto, Genre>().ReverseMap();
    }
}