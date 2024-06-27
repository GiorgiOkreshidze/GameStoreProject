using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IGameDbService
{
    public ICollection<GameEntity> GetAllGamesDb();
    
    public void CreateGameDb(GameEntity gameEntity);

    public void UpdateGameDb(GameEntity gameEntity);

    public void DeleteGameDb(string key);

    public GameEntity GetGameByKeyDb(string key);

    public GameEntity GetGameByIdDb(Guid id);

    public int GetGamesNumber();

    public ICollection<GenreEntity> GetGenresOfGameDb(string key);

    public ICollection<PlatformEntity> GetPlatformsOfGameDb(string key);
}