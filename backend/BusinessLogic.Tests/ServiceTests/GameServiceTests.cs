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
using Microsoft.AspNetCore.Http;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class GameServiceTests
{
    private readonly GameService _gameServiceTest;

    private readonly Mock<IGameDbService> _gameDbServiceMock = new();
    private readonly IMapper _gameMapper;
    private readonly Mock<IHttpContextAccessor> _accessor = new();
    private readonly Mock<GameValidator> _gameValidator = new();

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
            cfg.CreateMap<GameDto, Game>().ReverseMap();
        });
        _gameMapper = config.CreateMapper();
        _gameServiceTest = new GameService(
            _gameDbServiceMock.Object,
            _gameMapper,
            _accessor.Object,
            _gameValidator.Object);
    }

    /*[Fact]
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
    }*/

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
        Game game = _gameMapper.Map<GameDto, Game>(gameDto.Game);
        game.Genres = gameDto.Genres;
        game.Platforms = gameDto.Platforms;
        game.PublisherId = gameDto.Publisher;
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
}