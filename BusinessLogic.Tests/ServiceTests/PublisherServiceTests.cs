using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.Services;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;
using FluentAssertions;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class PublisherServiceTests
{
    private readonly PublisherService _publisherServiceTest;

    private readonly Mock<IPublisherDbService> _publisherDbServiceMock = new();
    private readonly IMapper _publisherMapper;
    private readonly Mock<IValidationsHandler> _validatorMock = new();

    public PublisherServiceTests()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
            cfg.CreateMap<PublisherEntity, Publisher>().ReverseMap();
            cfg.CreateMap<Publisher, CreatePublisherDto>().ReverseMap();
            cfg.CreateMap<Publisher, GetPublisherDto>().ReverseMap();
            cfg.CreateMap<Publisher, UpdatePublisherDto>().ReverseMap();
            cfg.CreateMap<PublisherDto, Publisher>().ReverseMap();
        });
        _publisherMapper = config.CreateMapper();
        _publisherServiceTest = new PublisherService(_publisherDbServiceMock.Object, _publisherMapper, _validatorMock.Object);
    }

    [Fact]
    public void PublisherService_GetPublisherByCompanyName_ReturnsPublisher()
    {
        // Arrange
        var publisherEntity = TestUtils.PublisherEntityUtil.CreatePublisherEntity();
        _publisherDbServiceMock.Setup(x => x.GetPublisherByCompanyNameDb(publisherEntity.CompanyName)).Returns(publisherEntity);

        var publisher = _publisherMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = _publisherMapper.Map<Publisher, GetPublisherDto>(publisher);

        // Act
        var result = _publisherServiceTest.GetPublisherByCompanyName(publisherEntity.CompanyName);

        // Assert
        Assert.Equal(publisherDto.Id, result.Id);
        Assert.Equal(publisherDto.CompanyName, result.CompanyName);
        Assert.Equal(publisherDto.HomePage, result.HomePage);
        Assert.Equal(publisherDto.Description, result.Description);
    }

    [Fact]
    public void PublisherService_DeletePublisher_DeletesPublisherEntity()
    {
        // Arrange
        var publisherEntity = TestUtils.PublisherEntityUtil.CreatePublisherEntity();
        _publisherDbServiceMock.Setup(x => x.DeletePublisherDb(publisherEntity.Id));

        // Act
        _publisherServiceTest.DeletePublisher(publisherEntity.Id);

        // Assert
        _publisherDbServiceMock.Verify(s => s.DeletePublisherDb(publisherEntity.Id), Times.Once);
    }

    [Fact]
    public void PublisherService_CreatePublisher_CreatesPublisherEntity()
    {
        // Arrange
        var publisherDto = TestUtils.PublisherEntityUtil.CreatePublisherDto();
        var publisher = _publisherMapper.Map<PublisherDto, Publisher>(publisherDto.Publisher);
        var publisherEntity = _publisherMapper.Map<Publisher, PublisherEntity>(publisher);
        _publisherDbServiceMock.Setup(x => x.CreatePublisherDb(publisherEntity));

        // Act
        _publisherServiceTest.CreatePublisher(publisherDto);

        // Assert
        _publisherDbServiceMock.Verify(db => db.CreatePublisherDb(It.IsAny<PublisherEntity>()), Times.Once);
    }

    [Fact]
    public void PublisherService_UpdatePublisher_UpdatesPublisherEntity()
    {
        // Arrange
        var publisherDto = TestUtils.PublisherEntityUtil.CreateUpdatePlatformDto();
        var publisher = _publisherMapper.Map<UpdatePublisherDto, Publisher>(publisherDto);
        var publisherEntity = _publisherMapper.Map<Publisher, PublisherEntity>(publisher);
        _publisherDbServiceMock.Setup(x => x.UpdatePublisherDb(publisherEntity));

        // Act
        _publisherServiceTest.UpdatePublisher(publisherDto);

        // Assert
        _publisherDbServiceMock.Verify(s => s.UpdatePublisherDb(It.IsAny<PublisherEntity>()), Times.Once);
    }

    [Fact]
    public void PublisherService_GetGamesOfPublisher_ReturnsGameDtos()
    {
        // Arrange
        var publisherEntity = TestUtils.PublisherEntityUtil.CreatePublisherEntity();
        _publisherDbServiceMock.Setup(x => x.GetGamesOfPublisherDb(publisherEntity.CompanyName)).Returns(publisherEntity.GameEntities);

        var games = _publisherMapper.Map<ICollection<GameEntity>, ICollection<Game>>(publisherEntity.GameEntities);
        var gameDtos = _publisherMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        // Act
        var result = _publisherServiceTest.GetGamesOfPublisher(publisherEntity.CompanyName);

        // Assert
        gameDtos.Zip(result).ToList().ForEach(pair => ValidateGames(pair.First, pair.Second));
    }

    [Fact]
    public void PublisherService_GetAllPublishers_ReturnsAllPublisherDtos()
    {
        // Arrange
        var publisherEntities = TestUtils.PublisherEntityUtil.CreatePublisherEntities();
        _publisherDbServiceMock.Setup(x => x.GetAllPublishersDb()).Returns(publisherEntities);

        var publishers = _publisherMapper.Map<ICollection<PublisherEntity>, ICollection<Publisher>>(publisherEntities);
        var publisherDtos = _publisherMapper.Map<ICollection<Publisher>, ICollection<GetPublisherDto>>(publishers);

        // Act
        var result = _publisherServiceTest.GetAllPublishers();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(publisherDtos);
    }

    private static void ValidateGames(GetGameDto gameDto, GetGameDto result)
    {
        gameDto.Name.Should().Be(result.Name);
        gameDto.Id.Should().Be(result.Id);
        gameDto.Key.Should().Be(result.Key);
        gameDto.Description.Should().Be(result.Description);
    }
}