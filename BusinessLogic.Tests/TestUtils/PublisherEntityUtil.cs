using BusinessLogicTests.ServiceTests;
using DataAccess.Entities;
using DTOs.PublisherDtos;
using static BusinessLogicTests.Constants.ConstantsPublisher;

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
            GameEntities = CreateGameEntities()
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
            GameEntities = CreateGameEntities()
        }).ToList();
    }
    
    private static ICollection<GameEntity> CreateGameEntities(int genreCount = 1)
    {
        return Enumerable.Range(0, genreCount).Select(index => new GameEntity
        {
            Name = PublisherEntityTest.GameNameFromIndex(index),
            Description = PublisherEntityTest.GameDescriptionFromIndex(index),
            Key = PublisherEntityTest.GameKeyFromIndex(index)
        }).ToList();
    }
    
    public static CreatePublisherDto CreatePublisherDto()
    {
        return new CreatePublisherDto
        {
            CompanyName = PublisherEntityTest.CompanyName,
            HomePage = PublisherEntityTest.HomePage,
            Description = PublisherEntityTest.Description,
        };
    }
    
    public static UpdatePublisherDto CreateUpdatePlatformDto()
    {
        return new UpdatePublisherDto
        {
            Id = PublisherEntityTest.Id,
            CompanyName = PublisherEntityTest.CompanyName,
            HomePage = PublisherEntityTest.HomePage,
            Description = PublisherEntityTest.Description,
        };
    }
}