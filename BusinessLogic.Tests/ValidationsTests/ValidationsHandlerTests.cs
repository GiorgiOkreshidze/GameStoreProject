using BusinessLogic.Exceptions;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using Moq;

namespace BusinessLogicTests.ValidationsTests;

public class ValidationsHandlerTests
{
    private readonly ValidationsHandler _validationsHandlerTest;

    private readonly Mock<IGameDbService> _gameDbServiceMock = new();
    private readonly Mock<IGenreDbService> _genreDbServiceMock = new();
    private readonly Mock<IPlatformDbService> _platformDbServiceMock = new();
    private readonly Mock<IPublisherDbService> _publisherDbServiceMock = new();

    public ValidationsHandlerTests()
    {
        _validationsHandlerTest = new ValidationsHandler(
            _gameDbServiceMock.Object,
            _genreDbServiceMock.Object,
            _platformDbServiceMock.Object,
            _publisherDbServiceMock.Object);
    }

    [Fact]
    public void ValidationsHandler_GenreNotExists_ThrowsException()
    {
        // Arrange
        var game = TestUtils.GameEntityUtil.CreateGame();

        _genreDbServiceMock.Setup(x => x.NotExists(game.Genres.FirstOrDefault())).Returns(true);

        // Act & Assert
        Assert.Throws<GenreNotExistsException>(() => _validationsHandlerTest.ValidateGenres(game.Genres));
    }

    [Fact]
    public void ValidationsHandler_PlatformNotExists_ThrowsException()
    {
        // Arrange
        var game = TestUtils.GameEntityUtil.CreateGame();

        _platformDbServiceMock.Setup(x => x.NotExists(game.Platforms.FirstOrDefault())).Returns(true);

        // Act & Assert
        Assert.Throws<PlatformNotExistsException>(() => _validationsHandlerTest.ValidatePlatforms(game.Platforms));
    }

    [Fact]
    public void ValidationsHandler_ValidateGameId_ThrowsException()
    {
        // Arrange
        var id = Guid.NewGuid();

        _gameDbServiceMock.Setup(x => x.NotExists(id)).Returns(true);

        // Act & Assert
        Assert.Throws<GameNotExistsException>(() => _validationsHandlerTest.ValidateGameId(id));
    }

    [Fact]
    public void ValidationsHandler_ValidateGameKey_ThrowsException()
    {
        // Arrange
        var key = "Game Key";

        _gameDbServiceMock.Setup(x => x.KeyNotExists(key)).Returns(true);

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _validationsHandlerTest.ValidateGameKey(key));
    }

    [Fact]
    public void ValidationsHandler_ValidatePublisherId_ThrowsException()
    {
        // Arrange
        var id = Guid.NewGuid();

        _publisherDbServiceMock.Setup(x => x.PublisherNotExists(id)).Returns(true);

        // Act & Assert
        Assert.Throws<PublisherNotExistsException>(() => _validationsHandlerTest.ValidatePublisherId(id));
    }

    [Fact]
    public void ValidationsHandler_ValidatePlatform_ThrowsException()
    {
        // Arrange
        var id = Guid.NewGuid();

        _platformDbServiceMock.Setup(x => x.NotExists(id)).Returns(true);

        // Act & Assert
        Assert.Throws<PlatformNotExistsException>(() => _validationsHandlerTest.ValidatePlatform(id));
    }

    [Fact]
    public void ValidationsHandler_ValidatePlatformType_ThrowsException()
    {
        // Arrange
        var type = "Platform Type";

        _platformDbServiceMock.Setup(x => x.TypeExists(type)).Returns(true);

        // Act & Assert
        Assert.Throws<PlatformTypeExistsException>(() => _validationsHandlerTest.ValidatePlatformType(type));
    }

    [Fact]
    public void ValidationsHandler_ValidateGenre_ThrowsException()
    {
        // Arrange
        var id = Guid.NewGuid();

        _genreDbServiceMock.Setup(x => x.NotExists(id)).Returns(true);

        // Act & Assert
        Assert.Throws<GenreNotExistsException>(() => _validationsHandlerTest.ValidateGenre(id));
    }

    [Fact]
    public void ValidationsHandler_ValidateGenreName_ThrowsException()
    {
        // Arrange
        var name = "Genre Name";

        _genreDbServiceMock.Setup(x => x.NameExists(name)).Returns(true);

        // Act & Assert
        Assert.Throws<GenreNameExistsException>(() => _validationsHandlerTest.ValidateGenreName(name));
    }

    [Fact]
    public void ValidationsHandler_ValidateCompanyName_ThrowsException()
    {
        // Arrange
        var companyName = "Publishers Company name";

        _publisherDbServiceMock.Setup(x => x.CompanyNameNotExists(companyName)).Returns(true);

        // Act & Assert
        Assert.Throws<Exception>(() => _validationsHandlerTest.ValidateCompanyName(companyName));
    }
}