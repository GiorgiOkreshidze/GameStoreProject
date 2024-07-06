using System.Collections;
using DataAccess.Entities;
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
            GenreEntities = CreateGenreEntities(),
            PlatformEntities = CreatePlatformEntities()
        };
    }
    
    public static ICollection<GenreEntity> CreateGenreEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GenreEntity
        {
            Name = GameEntityTest.GenreNameFromIndex(index)
        }).ToList();
    }
    
    public static ICollection<PlatformEntity> CreatePlatformEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new PlatformEntity
        {
            Type = GameEntityTest.PlatformTypeFromIndex(index)
        }).ToList();
    }
}