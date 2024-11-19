#pragma warning disable IDE0005
using DTOs.CommentDtos;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IGameService
{
    public GetPagedGameDto GetGames(GameFilterDto filter, GameSortDto sort, GamePaginationDto pagination);

    public void CreateGame(CreateGameDto createGameDto);

    public void UpdateGame(UpdateGameDto updateGameDto);

    public void DeleteGame(string key);

    public GetGameDto GetGameByKey(string key, bool countView = false);

    public GetGameDto GetGameById(Guid id, bool countView = false);

    public void AddGameInCart(string key);

    public ICollection<GetGameDto> GetAllGames();

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id);

    public ICollection<GetGameDto> GetGamesByGenreId(Guid id);

    public ICollection<GetGameDto> GetGamesOfPublisher(string companyName);
}