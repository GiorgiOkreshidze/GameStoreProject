using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.Services;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using DTOs.PublisherDtos;
using FluentAssertions;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class GameServiceTests
{
    private readonly GameService _gameServiceTest;

    private readonly Mock<IGameDbService> _gameDbServiceMock = new();
    private readonly IMapper _gameMapper;
    private readonly Mock<IValidationsHandler> _validatorMock = new();

    public GameServiceTests()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, UpdateGameDto>().ReverseMap();
            cfg.CreateMap<GenreEntity, Genre>().ReverseMap();
            cfg.CreateMap<Genre, GenreDto>().ReverseMap();
            cfg.CreateMap<PlatformEntity, Platform>().ReverseMap();
            cfg.CreateMap<Platform, PlatformDto>().ReverseMap();
            cfg.CreateMap<PublisherEntity, Publisher>().ReverseMap();
            cfg.CreateMap<Publisher, GetPublisherDto>().ReverseMap();
        });
        _gameMapper = config.CreateMapper();
        _gameServiceTest = new GameService(_gameDbServiceMock.Object, _gameMapper, _validatorMock.Object);
    }

    [Fact]
    public void GameService_GetAllGames_ReturnsAllGameDtos()
    {
        // Arrange
        var gameEntities = TestUtils.GameEntityUtil.CreateGameEntities();
        _gameDbServiceMock.Setup(x => x.GetAllGamesDb()).Returns(gameEntities);

        var games = _gameMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = _gameMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        // Act
        var result = _gameServiceTest.GetAllGames();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(gameDtos);
    }

    [Fact]
    public void GameService_GetGameByKey_ReturnsGameDtoByKey()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByKeyDb(gameEntity.Key)).Returns(gameEntity);

        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);

        // Act
        var result = _gameServiceTest.GetGameByKey(gameEntity.Key);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(gameDto);
    }

    [Fact]
    public void GameService_GetPublisherOfGame_ReturnsPublisherDto()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetPublisherOfGameDb(gameEntity.Key)).Returns(gameEntity.PublisherEntity);

        var publisher = _gameMapper.Map<PublisherEntity, Publisher>(gameEntity.PublisherEntity);
        var publisherDto = _gameMapper.Map<Publisher, GetPublisherDto>(publisher);

        // Act
        var result = _gameServiceTest.GetPublisherOfGame(gameEntity.Key);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(publisherDto);
    }

    [Fact]
    public void GameService_GetGameById_ReturnsGamDtoById()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByIdDb(gameEntity.Id)).Returns(gameEntity);

        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);

        // Act
        var result = _gameServiceTest.GetGameById(gameEntity.Id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(gameDto);
    }

    [Fact]
    public void GameService_GetGenresOfGame_ReturnsGenreDtos()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGenresOfGameDb(gameEntity.Key)).Returns(gameEntity.GenreEntities);

        var genres = _gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(gameEntity.GenreEntities);
        var genreDtos = _gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        // Act
        var result = _gameServiceTest.GetGenresOfGame(gameEntity.Key);

        // Assert
        result.Should().NotBeNull();
        genreDtos.Zip(result).ToList().ForEach(pair => ValidateGenres(pair.First, pair.Second));
    }

    [Fact]
    public void GameService_GetPlatformsOfGame_ReturnsPlatformDtos()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetPlatformsOfGameDb(gameEntity.Key)).Returns(gameEntity.PlatformEntities);

        var platform = _gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(gameEntity.PlatformEntities);
        var platformDtos = _gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);

        // Act
        var result = _gameServiceTest.GetPlatformsOfGame(gameEntity.Key);

        // Assert
        result.Should().NotBeNull();
        platformDtos.Zip(result).ToList().ForEach(pair => ValidatePlatforms(pair.First, pair.Second));
    }

    [Fact]
    public void GameService_DeleteGame_DeletesGameEntity()
    {
        // Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByKeyDb(gameEntity.Key)).Returns(gameEntity);
        _gameDbServiceMock.Setup(x => x.DeleteGameDb(gameEntity));

        // Act
        _gameServiceTest.DeleteGame(gameEntity.Key);

        // Assert
        _gameDbServiceMock.Verify(s => s.GetGameByKeyDb(gameEntity.Key), Times.Once);
        _gameDbServiceMock.Verify(s => s.DeleteGameDb(gameEntity), Times.Once);
    }

    [Fact]
    public void GameService_CreateGame_CreatesGameEntity()
    {
        // Arrange
        var gameDto = TestUtils.GameEntityUtil.CreateGameDto();
        var game = _gameMapper.Map<CreateGameDto, Game>(gameDto);
        var gameEntity = _gameMapper.Map<Game, GameEntity>(game);
        _gameDbServiceMock.Setup(x => x.CreateGameDb(gameEntity));

        // Act
        _gameServiceTest.CreateGame(gameDto);

        // Assert
        _gameDbServiceMock.Verify(db => db.CreateGameDb(It.IsAny<GameEntity>()), Times.Once);
    }

    [Fact]
    public void GameService_UpdateGame_UpdatesGameEntity()
    {
        // Arrange
        var gameDto = TestUtils.GameEntityUtil.CreateUpdateGameDto();
        var game = _gameMapper.Map<UpdateGameDto, Game>(gameDto);
        var gameEntity = _gameMapper.Map<Game, GameEntity>(game);
        _gameDbServiceMock.Setup(x => x.UpdateGameDb(gameEntity));

        // Act
        _gameServiceTest.UpdateGame(gameDto);

        // Assert
        _gameDbServiceMock.Verify(s => s.UpdateGameDb(It.IsAny<GameEntity>()), Times.Once);
    }

    private static void ValidateGenres(GenreDto genreDto, GenreDto result)
    {
        genreDto.Name.Should().Be(result.Name);
        genreDto.Id.Should().Be(result.Id);
    }

    private static void ValidatePlatforms(PlatformDto platformDto, PlatformDto result)
    {
        platformDto.Type.Should().Be(result.Type);
        platformDto.Id.Should().Be(result.Id);
    }
}