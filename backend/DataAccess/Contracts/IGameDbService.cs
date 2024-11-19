using DataAccess.Entities;
using DTOs.GameDtos;

namespace DataAccess.Contracts;

public interface IGameDbService
{
    public ICollection<GameEntity> GetGamesDb(GameFilterDto filter);

    public void CreateGameDb(GameEntity gameEntity);

    public void UpdateGameDb(GameEntity gameEntity);

    public void DeleteGameDb(GameEntity gameEntity);

    public GameEntity GetGameByKeyDb(string key);

    public GameEntity GetGameByIdDb(Guid id);

    public int GetGamesNumber();

    public void AddGameEntityToCartDb(GameEntity gameEntity);

    public Guid GetGameIdByKey(string key);

    public bool NotExists(Guid id);

    public bool KeyNotExists(string key);

    public ICollection<GameEntity> GetGamesWithoutFilterDb();

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id);

    public ICollection<GameEntity> GetGamesByGenreId(Guid id);

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName);

    public void IncreaseGameViews(Guid gameId);
}