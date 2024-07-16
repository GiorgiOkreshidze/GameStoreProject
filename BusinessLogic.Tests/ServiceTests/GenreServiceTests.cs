using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.Services;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using FluentAssertions;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class GenreServiceTests
{
    private readonly GenreService _genreServiceTest;

    private readonly Mock<IGenreDbService> _genreDbServiceMock = new();
    private readonly IMapper _genreMapper;
    private readonly Mock<IValidationsHandler> _validatorMock = new();

    public GenreServiceTests()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
            cfg.CreateMap<GenreEntity, Genre>().ReverseMap();
            cfg.CreateMap<Genre, CreateGenreDto>().ReverseMap();
            cfg.CreateMap<Genre, GetGenreDto>().ReverseMap();
            cfg.CreateMap<Genre, GenreDto>().ReverseMap();
            cfg.CreateMap<UpdateGenreDto, Genre>().ReverseMap();
            cfg.CreateMap<GGenreDto, Genre>().ReverseMap();
        });
        _genreMapper = config.CreateMapper();
        _genreServiceTest = new GenreService(_genreDbServiceMock.Object, _genreMapper, _validatorMock.Object);
    }

    [Fact]
    public void GenreService_DeleteGenre_DeletesGenreEntity()
    {
        // Arrange
        var genreEntity = TestUtils.GenreEntityUtil.CreateGenreEntity();
        _genreDbServiceMock.Setup(x => x.GetGenreByGuid(genreEntity.Id)).Returns(genreEntity);
        _genreDbServiceMock.Setup(x => x.DeleteGenreDb(genreEntity));

        // Act
        _genreServiceTest.DeleteGenre(genreEntity.Id);

        // Assert
        _genreDbServiceMock.Verify(s => s.GetGenreByGuid(genreEntity.Id), Times.Once);
        _genreDbServiceMock.Verify(s => s.DeleteGenreDb(genreEntity), Times.Once);
    }

    [Fact]
    public void GenreService_GetGenre_ReturnsGenre()
    {
        // Arrange
        var genreEntity = TestUtils.GenreEntityUtil.CreateGenreEntity();
        _genreDbServiceMock.Setup(x => x.GetGenreByGuid(genreEntity.Id)).Returns(genreEntity);

        var genre = _genreMapper.Map<GenreEntity, Genre>(genreEntity);
        var genreDto = _genreMapper.Map<Genre, GetGenreDto>(genre);

        // Act
        var result = _genreServiceTest.GetGenre(genreEntity.Id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(genreDto);
    }

    [Fact]
    public void GenreService_GetGamesByGenreId_ReturnsGameDtos()
    {
        // Arrange
        var genreEntity = TestUtils.GenreEntityUtil.CreateGenreEntity();
        _genreDbServiceMock.Setup(x => x.GetGamesByGenreId(genreEntity.Id)).Returns(genreEntity.GameEntities);

        var games = _genreMapper.Map<ICollection<GameEntity>, ICollection<Game>>(genreEntity.GameEntities);
        var gameDtos = _genreMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        // Act
        var result = _genreServiceTest.GetGamesByGenreId(genreEntity.Id);

        // Assert
        gameDtos.Zip(result).ToList().ForEach(pair => ValidateGames(pair.First, pair.Second));
    }

    [Fact]
    public void GenreService_CreateGenre_CreatesGameEntity()
    {
        // Arrange
        var genreDto = TestUtils.GenreEntityUtil.CreateGenreDto();
        var genre = _genreMapper.Map<GGenreDto, Genre>(genreDto.Genre);
        var genreEntity = _genreMapper.Map<Genre, GenreEntity>(genre);
        _genreDbServiceMock.Setup(x => x.CreateGenreDb(genreEntity));

        // Act
        _genreServiceTest.CreateGenre(genreDto);

        // Assert
        _genreDbServiceMock.Verify(db => db.CreateGenreDb(It.IsAny<GenreEntity>()), Times.Once);
    }

    [Fact]
    public void GenreService_UpdateGenre_UpdatesGenreEntity()
    {
        // Arrange
        var genreDto = TestUtils.GenreEntityUtil.CreateUpdateGenreDto();
        var genre = _genreMapper.Map<UpdateGenreDto, Genre>(genreDto);
        var genreEntity = _genreMapper.Map<Genre, GenreEntity>(genre);
        _genreDbServiceMock.Setup(x => x.UpdateGenreDb(genreEntity));

        // Act
        _genreServiceTest.UpdateGenre(genreDto);

        // Assert
        _genreDbServiceMock.Verify(s => s.UpdateGenreDb(It.IsAny<GenreEntity>()), Times.Once);
    }

    [Fact]
    public void GenreService_GetAllGenres_ReturnsAllGenreDtos()
    {
        // Arrange
        var genreEntities = TestUtils.GenreEntityUtil.CreateGenreEntities();
        _genreDbServiceMock.Setup(x => x.GetAllGenresDb()).Returns(genreEntities);

        var genres = _genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = _genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        // Act
        var result = _genreServiceTest.GetAllGenres();

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(genreDtos);
    }

#pragma warning disable SA1010
    [Fact]
    public void GenreService_GetSubGenres_ReturnsAllSubGenreDtos()
    {
        // Arrange
        var genreEntity = TestUtils.GenreEntityUtil.CreateGenreEntity();
        ICollection<GenreEntity> genreEntities = [genreEntity];
        _genreDbServiceMock.Setup(x => x.GetSubGenresDb(genreEntity.Id)).Returns(genreEntities);

        var genres = _genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = _genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        // Act
        var result = _genreServiceTest.GetSubGenres(genreEntity.Id);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(genreDtos);
    }

    private static void ValidateGames(GetGameDto gameDto, GetGameDto result)
    {
        gameDto.Name.Should().Be(result.Name);
        gameDto.Id.Should().Be(result.Id);
        gameDto.Key.Should().Be(result.Key);
        gameDto.Description.Should().Be(result.Description);
    }
}