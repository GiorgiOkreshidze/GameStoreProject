using DataAccess.Entities;
using DTOs.PublisherDtos;
using static BusinessLogicTests.Constants.Constants;

namespace BusinessLogicTests.TestUtils;

public static class PublisherEntityUtil
{
    public static PublisherEntity CreatePublisherEntity()
    {
        return new PublisherEntity
        {
            Id = PublisherEntityTest.Id,
            CompanyName = PublisherEntityTest.CompanyName,
            HomePage = PublisherEntityTest.HomePage,
            Description = PublisherEntityTest.Description,
            GameEntities = CreateGameEntities(),
        };
    }

    public static ICollection<PublisherEntity> CreatePublisherEntities(int gameCount = 1)
    {
        return Enumerable.Range(0, gameCount).Select(index => new PublisherEntity
        {
            Id = PublisherEntityTest.Id,
            CompanyName = PublisherEntityTest.CompanyName + index,
            HomePage = PublisherEntityTest.HomePage + index,
            Description = PublisherEntityTest.Description + index,
            GameEntities = CreateGameEntities(),
        }).ToList();
    }

    public static CreatePublisherDto CreatePublisherDto()
    {
        return new CreatePublisherDto
        {
            Publisher = new PublisherDto
            {
                CompanyName = PublisherEntityTest.CompanyName,
                HomePage = PublisherEntityTest.HomePage,
                Description = PublisherEntityTest.Description,
            },
        };
    }

    public static UpdatePublisherDto CreateUpdatePlatformDto()
    {
        return new UpdatePublisherDto
        {
            Publisher = new PublisherDtoWithId()
            {
                Id = PublisherEntityTest.Id,
                CompanyName = PublisherEntityTest.CompanyName,
                HomePage = PublisherEntityTest.HomePage,
                Description = PublisherEntityTest.Description,
            },
        };
    }

#pragma warning disable CA1859
    private static ICollection<GameEntity> CreateGameEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GameEntity
        {
            Name = PublisherEntityTest.GameNameFromIndex(index),
            Description = PublisherEntityTest.GameDescriptionFromIndex(index),
            Key = PublisherEntityTest.GameKeyFromIndex(index),
        }).ToList();
    }
}