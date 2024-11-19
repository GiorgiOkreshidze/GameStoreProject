using DataAccess.Entities;
using DTOs.PlatformDtos;
using static BusinessLogicTests.Constants.Constants;

namespace BusinessLogicTests.TestUtils;

public static class PlatformEntityUtil
{
    public static PlatformEntity CreatePlatformEntity()
    {
        return new PlatformEntity
        {
            Id = PlatformEntityTest.Id,
            Type = PlatformEntityTest.Type,
            GameEntities = CreateGameEntities(),
        };
    }

    public static ICollection<PlatformEntity> CreatePlatformEntities(int gameCount = 1)
    {
        return Enumerable.Range(0, gameCount).Select(index => new PlatformEntity
        {
            Id = PlatformEntityTest.Id,
            Type = PlatformEntityTest.Type + index,
            GameEntities = CreateGameEntities(),
        }).ToList();
    }

    public static UpdatePlatformDto CreateUpdatePlatformDto()
    {
        return new UpdatePlatformDto
        {
            Platform = new PlatformDto
            {
                Id = PlatformEntityTest.Id,
                Type = PlatformEntityTest.Type,
            },
        };
    }

    public static CreatePlatformDto CreatePlatformDto()
    {
        return new CreatePlatformDto
        {
            Platform = new PlatformDtoWithoutId
            {
                Type = PlatformEntityTest.Type,
            },
        };
    }

#pragma warning disable CA1859
    private static ICollection<GameEntity> CreateGameEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GameEntity
        {
            Name = PlatformEntityTest.GameNameFromIndex(index),
            Description = PlatformEntityTest.GameDescriptionFromIndex(index),
            Key = PlatformEntityTest.GameKeyFromIndex(index),
        }).ToList();
    }
}