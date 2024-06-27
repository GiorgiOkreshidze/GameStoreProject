using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;

namespace BusinessLogic.Services;

public class GenreService : IGenreService
{
    private readonly IMapper _genreMapper;
    private readonly IGenreDbService _genreDbService;

    public GenreService(IGenreDbService genreDbService, IMapper genreMapper)
    {
        _genreDbService = genreDbService;
        _genreMapper = genreMapper;

    }

    public void CreateGenre(CreateGenreDto createGenreDto)
    {
        var genre = _genreMapper.Map<CreateGenreDto, Genre>(createGenreDto);
        
        genre.Id = Guid.NewGuid();

        var genreEntity = _genreMapper.Map<Genre, GenreEntity>(genre);
        
        _genreDbService.CreateGenreDb(genreEntity);
        
    }

    public ICollection<GenreDto> GetAllGenres()
    {
        var genreEntities = _genreDbService.GetAllGenresDb();

        var genre = _genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = _genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public void UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        var updateGenre = _genreMapper.Map<UpdateGenreDto, Genre>(updateGenreDto);
        var updateGenreEntity = _genreMapper.Map<Genre, GenreEntity>(updateGenre);

        _genreDbService.UpdateGenreDb(updateGenreEntity);
    }

    public void DeleteGenre(Guid id)
    {
        _genreDbService.DeleteGenreDb(id);
    }

    public GetGenreDto GetGenre(Guid id)
    {
        var genreEntity = _genreDbService.GetGenreByGuid(id);
        
        var genre = _genreMapper.Map<GenreEntity, Genre>(genreEntity);
        var getGenreDto = _genreMapper.Map<Genre, GetGenreDto>(genre);

        return getGenreDto;
    }

    public ICollection<GetGameDto> GetGamesByGenreId(Guid id)
    {
        var gameEntities = _genreDbService.GetGamesByGenreId(id);
        
        var game = _genreMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = _genreMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);
        
        return gameDtos;
    }

    public ICollection<GenreDto> GetSubGenres(Guid id)
    {
        var genreEntities = _genreDbService.GetSubGenresDb(id);

        var genre = _genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = _genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }
}