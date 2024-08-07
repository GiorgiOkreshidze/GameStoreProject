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

    public GetGameDto GetGameByKey(string key);

    public GetGameDto GetGameById(Guid id);

    public ICollection<GenreDto> GetGenresOfGame(string key);

    public ICollection<PlatformDto> GetPlatformsOfGame(string key);

    public GetPublisherDto GetPublisherOfGame(string key);

    public void AddGameInCart(string key);

    public void AddCommentAsQuote(string key, AddCommentDto addCommentDto);

    public void AddCommentAsReply(string key, AddCommentDto addCommentDto);

    public void AddComment(string key, AddCommentDto addCommentDto);

    public ICollection<GetCommentDto> GetComments(string key);

    public void DeleteComment(string key, Guid id);
}