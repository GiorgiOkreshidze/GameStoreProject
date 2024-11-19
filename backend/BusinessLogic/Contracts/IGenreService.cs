#pragma warning disable IDE0005
using DTOs.GameDtos;
using DTOs.GenreDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IGenreService
{
    public void CreateGenre(CreateGenreDto createGenreDto);

    public ICollection<GenreDto> GetAllGenres();

    public void UpdateGenre(UpdateGenreDto updateGenreDto);

    public void DeleteGenre(Guid id);

    public GetGenreDto GetGenre(Guid id);

    public ICollection<GenreDto> GetSubGenres(Guid id);

    public ICollection<GenreDto> GetGenresOfGame(string key);
}