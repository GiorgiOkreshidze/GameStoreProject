using DataAccess.Entities;
using DTOs.GameDtos;
using X.PagedList;

namespace DataAccess.Contracts;

public interface IGameDbService
{
    public IPagedList<GameEntity> GetGamesDb(GameFilterDto filter, GameSortDto sort, GamePaginationDto pagination);

    public void CreateGameDb(GameEntity gameEntity);

    public void UpdateGameDb(GameEntity gameEntity);

    public void DeleteGameDb(GameEntity gameEntity);

    public GameEntity GetGameByKeyDb(string key);

    public GameEntity GetGameByIdDb(Guid id);

    public int GetGamesNumber();

    public ICollection<GenreEntity> GetGenresOfGameDb(string key);

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key);

    public PublisherEntity GetPublisherOfGameDb(string key);

    public void AddGameEntityToCartDb(GameEntity gameEntity);

    public void AddCommentDb(string key, CommentEntity commentEntity);

    public ICollection<CommentEntity> GetCommentsDb(string key);

    public CommentEntity GetCommentById(Guid? commentId);

    public Guid GetGameIdByKey(string key);

    public void DeleteCommentDb(string key, Guid id);

    public bool IsUserBanned(string name);

    public bool NotExists(Guid id);

    public bool KeyNotExists(string key);
}