using BusinessLogic.Models;
using DataAccess.Entities;
using DTOs.GameDtos;
using static BusinessLogicTests.Constants.Constants;

namespace BusinessLogicTests.TestUtils;

public static class GameEntityUtil
{
    public static GameEntity CreateGameEntity()
    {
        return new GameEntity
        {
            Id = GameEntityTest.Id,
            Name = GameEntityTest.Name,
            Key = GameEntityTest.Key,
            Description = GameEntityTest.Description,
            UnitInStock = GameEntityTest.UnitInStock,
            Discount = GameEntityTest.Discount,
            Price = GameEntityTest.Price,
            PublisherId = GameEntityTest.PublisherId,
            PublisherEntity = PublisherEntityUtil.CreatePublisherEntity(),
            GenreEntities = CreateGenreEntities(),
            PlatformEntities = CreatePlatformEntities(),
        };
    }

    public static Game CreateGame()
    {
        return new Game
        {
            Id = GameEntityTest.Id,
            Name = GameEntityTest.Name,
            Key = GameEntityTest.Key,
            Description = GameEntityTest.Description,
            UnitInStock = GameEntityTest.UnitInStock,
            Discount = GameEntityTest.Discount,
            Price = GameEntityTest.Price,
            PublisherId = GameEntityTest.PublisherId,
            Platforms = CreateGuids(),
            Genres = CreateGuids(),
        };
    }

    public static UpdateGameDto CreateUpdateGameDto()
    {
        return new UpdateGameDto
        {
            Game = new GameDtoWithId
            {
                Id = GameEntityTest.Id,
                Name = GameEntityTest.Name,
                Key = GameEntityTest.Key,
                Description = GameEntityTest.Description,
                UnitInStock = GameEntityTest.UnitInStock,
                Discount = GameEntityTest.Discount,
                Price = GameEntityTest.Price,
            },
            PublisherId = GameEntityTest.PublisherId,
            Genres = CreateGenreEntityIds(),
            Platforms = CreatePlatformEntityIds(),
        };
    }

    public static ICollection<GameEntity> CreateGameEntities(int gameCount = 1)
    {
        return Enumerable.Range(0, gameCount).Select(index => new GameEntity
        {
            Id = GameEntityTest.Id,
            Name = GameEntityTest.Name + index,
            Key = GameEntityTest.Key + index,
            Description = GameEntityTest.Description + index,
            UnitInStock = GameEntityTest.UnitInStock + index,
            Discount = GameEntityTest.Discount + index,
            Price = GameEntityTest.Price + index,
            PublisherId = GameEntityTest.PublisherId,
            GenreEntities = CreateGenreEntities(),
            PlatformEntities = CreatePlatformEntities(),
        }).ToList();
    }

    public static CreateGameDto CreateGameDto()
    {
        return new CreateGameDto
        {
            Game = new GameDto
            {
                Name = GameEntityTest.Name,
                Key = GameEntityTest.Key,
                Description = GameEntityTest.Description,
                UnitInStock = GameEntityTest.UnitInStock,
                Discount = GameEntityTest.Discount,
                Price = GameEntityTest.Price,
            },
            Genres = CreateGenreEntityIds(),
            Platforms = CreatePlatformEntityIds(),
            Publisher = GameEntityTest.PublisherId,
        };
    }

#pragma warning disable CA1859
    private static ICollection<Guid> CreateGuids(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => Guid.NewGuid()).ToList();
    }

    private static ICollection<GenreEntity> CreateGenreEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GenreEntity
        {
            Name = GameEntityTest.GenreNameFromIndex(index),
        }).ToList();
    }

    private static ICollection<PlatformEntity> CreatePlatformEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new PlatformEntity
        {
            Type = GameEntityTest.PlatformTypeFromIndex(index),
        }).ToList();
    }

    private static ICollection<Guid> CreateGenreEntityIds(int genreIdsCount = 1)
    {
        return Enumerable.Range(0, genreIdsCount).Select(index => Guid.NewGuid()).ToList();
    }

    private static ICollection<Guid> CreatePlatformEntityIds(int platformIdsCount = 1)
    {
        return Enumerable.Range(0, platformIdsCount).Select(index => Guid.NewGuid()).ToList();
    }
}