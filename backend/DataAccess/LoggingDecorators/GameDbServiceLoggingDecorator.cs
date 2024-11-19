using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class GameDbServiceLoggingDecorator(IGameDbService gameDbService, IChangeLogMongoService logMongoService, IOrderDbService orderDbService) : IGameDbService
{
    private const string EntityName = "Game";

    public ICollection<GameEntity> GetGamesDb(GameFilterDto filter)
    {
        return gameDbService.GetGamesDb(filter);
    }

    public void CreateGameDb(GameEntity gameEntity)
    {
        gameDbService.CreateGameDb(gameEntity);
        logMongoService.LogChange(EntityName, "Add Game", null, gameEntity);
    }

    public void UpdateGameDb(GameEntity gameEntity)
    {
        var oldGameEntiy = gameDbService.GetGameByIdDb(gameEntity.Id);
        gameDbService.UpdateGameDb(gameEntity);
        logMongoService.LogChange(EntityName, "Update Game", oldGameEntiy, gameEntity);
    }

    public void DeleteGameDb(GameEntity gameEntity)
    {
        var oldGameEntiy = gameDbService.GetGameByIdDb(gameEntity.Id);
        gameDbService.DeleteGameDb(gameEntity);
        logMongoService.LogChange(EntityName, "Delete Game", oldGameEntiy, gameEntity);
    }

    public GameEntity GetGameByKeyDb(string key)
    {
        return gameDbService.GetGameByKeyDb(key);
    }

    public GameEntity GetGameByIdDb(Guid id)
    {
        return gameDbService.GetGameByIdDb(id);
    }

    public int GetGamesNumber()
    {
        return gameDbService.GetGamesNumber();
    }

    public void AddGameEntityToCartDb(GameEntity gameEntity)
    {
        var oldCart = orderDbService.GetCartDb();
        gameDbService.AddGameEntityToCartDb(gameEntity);
        var newCart = orderDbService.GetCartDb();
        logMongoService.LogChange("Cart", "Add Game To Cart", oldCart, newCart);
    }

    public Guid GetGameIdByKey(string key)
    {
        return gameDbService.GetGameIdByKey(key);
    }

    public bool NotExists(Guid id)
    {
        return gameDbService.NotExists(id);
    }

    public bool KeyNotExists(string key)
    {
        return gameDbService.KeyNotExists(key);
    }

    public ICollection<GameEntity> GetGamesWithoutFilterDb()
    {
        return gameDbService.GetGamesWithoutFilterDb();
    }

    public ICollection<GameEntity> GetGamesByPlatformId(Guid id)
    {
        return gameDbService.GetGamesByPlatformId(id);
    }

    public ICollection<GameEntity> GetGamesByGenreId(Guid id)
    {
        return gameDbService.GetGamesByGenreId(id);
    }

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName)
    {
        return gameDbService.GetGamesOfPublisherDb(companyName);
    }

    public void IncreaseGameViews(Guid gameId)
    {
        gameDbService.IncreaseGameViews(gameId);
    }
}