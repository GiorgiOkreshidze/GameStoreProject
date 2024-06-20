using BusinessLogic.Models;
using Gamestore.Dtos;

namespace BusinessLogic.Services;

public interface IGameService
{
    public GetGameDto getGame();
    public void createGame(CreateGameDto createGameDto);

    public GetGameDto getGameByKey(string key);
}