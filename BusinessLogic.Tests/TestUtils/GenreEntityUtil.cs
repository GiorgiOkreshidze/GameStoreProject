using DataAccess.Entities;
using DTOs.GenreDtos;
using static BusinessLogicTests.Constants.ConstantsGerne;

namespace BusinessLogicTests.TestUtils;

public static class GenreEntityUtil
{
    public static GenreEntity CreateGenreEntity()
    {
        return new GenreEntity
        {
            Id = GenreEntityTest.Id,
            Name = GenreEntityTest.Name,
            ParentGenreId = GenreEntityTest.ParentGenreId,
            ParentGenre = CreateSubGenreEntity(),
            GameEntities = CreateGameEntities(),
        };
    }

    public static CreateGenreDto CreateGenreDto()
    {
        return new CreateGenreDto
        {
            Name = GenreEntityTest.Name,
            ParentGenreId = GenreEntityTest.ParentGenreId,
        };
    }

    public static UpdateGenreDto CreateUpdateGenreDto()
    {
        return new UpdateGenreDto
        {
            Id = GenreEntityTest.Id,
            Name = GenreEntityTest.Name,
            ParentGenreId = GenreEntityTest.ParentGenreId,
        };
    }

    public static ICollection<GenreEntity> CreateGenreEntities(int gameCount = 1)
    {
        return Enumerable.Range(0, gameCount).Select(index => new GenreEntity
        {
            Id = GenreEntityTest.Id,
            Name = GenreEntityTest.Name + index,
            ParentGenreId = GenreEntityTest.ParentGenreId,
            GameEntities = CreateGameEntities(),
        }).ToList();
    }

    private static GenreEntity CreateSubGenreEntity()
    {
        return new GenreEntity
        {
            Id = GenreEntityTest.Id,
            Name = GenreEntityTest.Name,
            ParentGenreId = null,
            ParentGenre = null,
            GameEntities = CreateGameEntities(),
        };
    }

#pragma warning disable CA1859
    private static ICollection<GameEntity> CreateGameEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GameEntity
        {
            Name = GenreEntityTest.GameNameFromIndex(index),
            Description = GenreEntityTest.GameDescriptionFromIndex(index),
            Key = GenreEntityTest.GameKeyFromIndex(index),
        }).ToList();
    }
}