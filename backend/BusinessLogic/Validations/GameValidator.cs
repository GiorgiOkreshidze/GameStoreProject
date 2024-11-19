using BusinessLogic.HelperFunctions;
using DataAccess.Contracts;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Validations;
#pragma warning disable IDE0270

public class GameValidator(IHttpContextAccessor httpContextAccessor,
    IGameDbService gameDbService) : Validator(httpContextAccessor)
{
    public void CanBuyGame(Guid id, int itemsNeeded = 1)
    {
        CanBuyGame(gameDbService.GetGameByIdDb(id).Key, itemsNeeded);
    }

    public void CanBuyGame(string gameKey, int itemsNeeded = 1)
    {
        var game = gameDbService.GetGameByKeyDb(gameKey);

        if (game == null)
        {
            throw new InvalidDataException("GameDoesNotExist");
        }

        if (game.Deleted)
        {
            throw new InvalidOperationException("Game is deleted");
        }

        if (game.UnitInStock <= itemsNeeded)
        {
            throw new InvalidOperationException("Not enough items in stock");
        }
    }

    public void DeleteGame(string gameKey)
    {
        var game = gameDbService.GetGameByKeyDb(gameKey);

        if (game == null)
        {
            throw new InvalidDataException("GameDoesNotExist");
        }

        if (game.Deleted)
        {
            throw new InvalidOperationException("Game is already deleted");
        }
    }

    public void UpdateGame(string gameKey)
    {
        var game = gameDbService.GetGameByKeyDb(gameKey);

        if (game == null)
        {
            throw new InvalidDataException("GameDoesNotExist");
        }

        if (game.Deleted || _claims.HasPermission("ManageDeletedGames"))
        {
            throw new InvalidOperationException("Game is already deleted");
        }
    }
}