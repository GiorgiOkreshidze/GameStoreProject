using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Interface;

public class GameDbService : IGameDbService
{
    private GameDbContext _gameDbContext;
    
    public GameDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
    
    public void createGameDb(GameEntity gameEntity)
    {
        _gameDbContext.GameEntities.Add(gameEntity);
        _gameDbContext.SaveChanges();
    }

    public GameEntity getGameByKeyDb(string key)
    {
        throw new NotImplementedException();
    }

    public int getGamesNumber()
    {
        return _gameDbContext.GameEntities.Count();
    }


    public GameEntity getGameDb()
    {
        var game = new GameEntity()
        {
            Id = new Guid(),
            Name = "Cyberpunk",
            Key = "CP",
            description = "pretty good"
        };

        return game;
    }
}