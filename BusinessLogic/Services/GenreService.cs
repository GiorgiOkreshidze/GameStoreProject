using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;

namespace BusinessLogic.Services;

public class GenreService(IGenreDbService genreDbService, IMapper genreMapper, IValidationsHandler validator) : IGenreService
{
    public void CreateGenre(CreateGenreDto createGenreDto)
    {
        var genre = genreMapper.Map<CreateGenreDto, Genre>(createGenreDto);
        validator.ValidateGenreName(genre.Name);
        genre.Id = Guid.NewGuid();

        var genreEntity = genreMapper.Map<Genre, GenreEntity>(genre);

        genreDbService.CreateGenreDb(genreEntity);
    }

    public ICollection<GenreDto> GetAllGenres()
    {
        var genreEntities = genreDbService.GetAllGenresDb();

        var genre = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public void UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        var updateGenre = genreMapper.Map<UpdateGenreDto, Genre>(updateGenreDto);
        validator.ValidateGenre(updateGenre.Id);
        validator.ValidateGenreName(updateGenre.Name);
        var updateGenreEntity = genreMapper.Map<Genre, GenreEntity>(updateGenre);

        genreDbService.UpdateGenreDb(updateGenreEntity);
    }

    public void DeleteGenre(Guid id)
    {
        validator.ValidateGenre(id);
        var genreEntity = genreDbService.GetGenreByGuid(id);
        genreDbService.DeleteGenreDb(genreEntity);
    }

    public GetGenreDto GetGenre(Guid id)
    {
        validator.ValidateGenre(id);
        var genreEntity = genreDbService.GetGenreByGuid(id);

        var genre = genreMapper.Map<GenreEntity, Genre>(genreEntity);
        var getGenreDto = genreMapper.Map<Genre, GetGenreDto>(genre);

        return getGenreDto;
    }

    public ICollection<GetGameDto> GetGamesByGenreId(Guid id)
    {
        validator.ValidateGenre(id);
        var gameEntities = genreDbService.GetGamesByGenreId(id);

        var game = genreMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = genreMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);

        return gameDtos;
    }

    public ICollection<GenreDto> GetSubGenres(Guid id)
    {
        validator.ValidateGenre(id);
        var genreEntities = genreDbService.GetSubGenresDb(id);

        var genre = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }
}