using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.Services;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using FluentAssertions;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class GameServiceTests
{
    private readonly GameService _gameServiceTest;

    private readonly Mock<IGameDbService> _gameDbServiceMock = new Mock<IGameDbService>();
    private readonly Mock<IGenreDbService> _genreDbServiceMock = new Mock<IGenreDbService>();
    private readonly Mock<IPlatformDbService> _platformDbServiceMock = new Mock<IPlatformDbService>();
    private readonly Mock<IPublisherDbService> _publisherDbServiceMock = new Mock<IPublisherDbService>();
    private readonly IMapper _gameMapper;

    public GameServiceTests()
    {
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, UpdateGameDto>().ReverseMap();
            cfg.CreateMap<GenreEntity, Genre>().ReverseMap();
            cfg.CreateMap<Genre, GenreDto>().ReverseMap();
            cfg.CreateMap<PlatformEntity, Platform>().ReverseMap();
            cfg.CreateMap<Platform, PlatformDto>().ReverseMap();
        });
        _gameMapper = config.CreateMapper();
        _gameServiceTest = new GameService(_gameDbServiceMock.Object, _gameMapper, _genreDbServiceMock.Object,
            _platformDbServiceMock.Object, _publisherDbServiceMock.Object);
    }

    [Fact]
    public void GameService_GetAllGames_ReturnsAllGameDtos()
    {
        
    }


    [Fact]
    public void GameService_GetGameByKey_ReturnsGameDtoByKey()
    {
        //Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByKeyDb(gameEntity.Key)).Returns(gameEntity);
        
        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);
        
        //Act
        var result = _gameServiceTest.GetGameByKey(gameEntity.Key);
        
        //Assert
        Assert.Equal(gameDto.Id, result.Id);
        Assert.Equal(gameDto.Name, result.Name);
        Assert.Equal(gameDto.Key, result.Key);
        Assert.Equal(gameDto.Description, result.Description);
    }

    [Fact]
    public void GameService_GetGameById_ReturnsGamDtoById()
    {
        //Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByIdDb(gameEntity.Id)).Returns(gameEntity);
        
        var game = _gameMapper.Map<GameEntity, Game>(gameEntity);
        var gameDto = _gameMapper.Map<Game, GetGameDto>(game);

        //Act
        var result = _gameServiceTest.GetGameById(gameEntity.Id);

        //Assert
        Assert.Equal(gameDto.Id, result.Id);
        Assert.Equal(gameDto.Name, result.Name);
        Assert.Equal(gameDto.Key, result.Key);
        Assert.Equal(gameDto.Description, result.Description);
    }

    [Fact]
    public void GameService_GetGenresOfGame_ReturnsGenreDtos()
    {
        //Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGenresOfGameDb(gameEntity.Key)).Returns(gameEntity.GenreEntities);
        
        var genres = _gameMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(gameEntity.GenreEntities);
        var genreDtos = _gameMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);
        
        //Act 
        var result = _gameServiceTest.GetGenresOfGame(gameEntity.Key);
        
        //Assert
        genreDtos.Zip(result).ToList().ForEach(pair => ValidateGenres(pair.First, pair.Second));
    }

    private void ValidateGenres(GenreDto genreDto, GenreDto result)
    {
        genreDto.Name.Should().Be(result.Name);
        genreDto.Id.Should().Be(result.Id);
    }
    
    [Fact]
    public void GameService_GetPlatformsOfGame_ReturnsPlatformDtos()
    {
        //Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetPlatformsOfGameDb(gameEntity.Key)).Returns(gameEntity.PlatformEntities);
        
        var platform = _gameMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(gameEntity.PlatformEntities);
        var platformDtos = _gameMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);
        
        //Act 
        var result = _gameServiceTest.GetPlatformsOfGame(gameEntity.Key);
        
        //Assert
        platformDtos.Zip(result).ToList().ForEach(pair => ValidateGenres(pair.First, pair.Second));
    }

    private void ValidateGenres(PlatformDto platformDto, PlatformDto result)
    {
        platformDto.Type.Should().Be(result.Type);
        platformDto.Id.Should().Be(result.Id);
    }

    [Fact]
    public void GameService_DeleteGame_DeletesGameEntity()
    {
        //Arrange
        var gameEntity = TestUtils.GameEntityUtil.CreateGameEntity();
        _gameDbServiceMock.Setup(x => x.GetGameByKeyDb(gameEntity.Key)).Returns(gameEntity);
        _gameDbServiceMock.Setup(x => x.DeleteGameDb(gameEntity));
        
        //Act
        _gameServiceTest.DeleteGame(gameEntity.Key);
        
        //Assert=
        Assert.Null(_gameDbServiceMock.Object.GetGameByKeyDb(gameEntity.Key));
    }
}