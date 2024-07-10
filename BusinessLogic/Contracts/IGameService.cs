using System.Collections;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;

namespace BusinessLogic.Contracts;

public interface IGameService
{
    public ICollection<GetGameDto> GetAllGames();
    public void CreateGame(CreateGameDto createGameDto);

    public void UpdateGame(UpdateGameDto updateGameDto);

    public void DeleteGame(string key);

    public GetGameDto GetGameByKey(string key);

    public GetGameDto GetGameById(Guid id);

    public ICollection<GenreDto> GetGenresOfGame(string key);

    public ICollection<PlatformDto> GetPlatformsOfGame(string key);

    public GetPublisherDto GetPublisherOfGame(string key);
}