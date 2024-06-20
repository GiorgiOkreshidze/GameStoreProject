using DataAccess.Entities;

namespace DataAccess.Interface;

public interface IGameDbService
{
    public GameEntity getGameDb();
    
    public void createGameDb(GameEntity gameEntity);

    public GameEntity getGameByKeyDb(string key);

    public int getGamesNumber();
}