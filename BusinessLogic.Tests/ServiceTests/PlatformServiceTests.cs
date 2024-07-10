using AutoMapper;
using BusinessLogic.Models;
using BusinessLogic.Services;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using FluentAssertions;
using Moq;

namespace BusinessLogicTests.ServiceTests;

public class PlatformServiceTests
{
    private readonly PlatformService _platformServiceTest;

    private readonly Mock<IPlatformDbService> _platformDbServiceMock = new Mock<IPlatformDbService>();
    private readonly IMapper _platformMapper;
    private readonly Mock<IValidationsHandler> _validatorMock = new Mock<IValidationsHandler>();

    public PlatformServiceTests()
    {
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<GameEntity, Game>().ReverseMap();
            cfg.CreateMap<Game, GetGameDto>().ReverseMap();
            cfg.CreateMap<Game, CreateGameDto>().ReverseMap();
            cfg.CreateMap<PlatformEntity, Platform>().ReverseMap();
            cfg.CreateMap<Platform, GetPlatformDto>().ReverseMap();
            cfg.CreateMap<Platform, CreatePlatformDto>().ReverseMap();
            cfg.CreateMap<Platform, PlatformDto>().ReverseMap();
            cfg.CreateMap<Platform, UpdatePlatformDto>().ReverseMap();
        });
        _platformMapper = config.CreateMapper();
        _platformServiceTest = new PlatformService(_platformDbServiceMock.Object, _platformMapper, _validatorMock.Object);
    }
    
    [Fact]
    public void PlatformService_DeletePlatform_DeletesPlatformEntity()
    {
        //Arrange
        var platformEntity = TestUtils.PlatformEntityUtil.CreatePlatformEntity();
        _platformDbServiceMock.Setup(x => x.GetPlatformByGuid(platformEntity.Id)).Returns(platformEntity);
        _platformDbServiceMock.Setup(x => x.DeletePlatformDb(platformEntity));
        
        //Act
        _platformServiceTest.DeletePlatform(platformEntity.Id);
        
        //Assert
        _platformDbServiceMock.Verify(s => s.GetPlatformByGuid(platformEntity.Id), Times.Once);
        _platformDbServiceMock.Verify(s => s.DeletePlatformDb(platformEntity), Times.Once);
    }
    
    [Fact]
    public void PlatformService_GetPlatformById_ReturnsPlatform()
    {
        //Arrange
        var platformEntity = TestUtils.PlatformEntityUtil.CreatePlatformEntity();
        _platformDbServiceMock.Setup(x => x.GetPlatformByGuid(platformEntity.Id)).Returns(platformEntity);
        
        var platform = _platformMapper.Map<PlatformEntity, Platform>(platformEntity);
        var platformDto = _platformMapper.Map<Platform, PlatformDto>(platform);

        //Act
        var result = _platformServiceTest.GetPlatformById(platformEntity.Id);

        //Assert
        Assert.Equal(platformDto.Id, result.Id);
        Assert.Equal(platformDto.Type, result.Type);
    }
    
    [Fact]
    public void PlatformService_GetGamesByPlatformId_ReturnsGameDtos()
    {
        //Arrange
        var platformEntity = TestUtils.PlatformEntityUtil.CreatePlatformEntity();
        _platformDbServiceMock.Setup(x => x.GetGamesByPlatformId(platformEntity.Id)).Returns(platformEntity.GameEntities);
        
        var games = _platformMapper.Map<ICollection<GameEntity>, ICollection<Game>>(platformEntity.GameEntities);
        var gameDtos = _platformMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);
        
        //Act 
        var result = _platformServiceTest.GetGamesByPlatformId(platformEntity.Id);
        
        //Assert
        gameDtos.Zip(result).ToList().ForEach(pair => ValidateGames(pair.First, pair.Second));
    }

    private void ValidateGames(GetGameDto gameDto, GetGameDto result)
    {
        gameDto.Name.Should().Be(result.Name);
        gameDto.Id.Should().Be(result.Id);
        gameDto.Key.Should().Be(result.Key);
        gameDto.Description.Should().Be(result.Description);
    }
    
    [Fact]
    public void PlatformService_CreatePlatform_CreatesPlatformEntity()
    {
        //Arrange
        var platformDto = TestUtils.PlatformEntityUtil.CreatePlatformDto();
        var platform = _platformMapper.Map<CreatePlatformDto, Platform>(platformDto);
        var platformEntity = _platformMapper.Map<Platform, PlatformEntity>(platform);
        _platformDbServiceMock.Setup(x => x.CreatePlatformDb(platformEntity));
        
        //Act
        _platformServiceTest.CreatePlatform(platformDto);
        
        //Assert
        _platformDbServiceMock.Verify(db => db.CreatePlatformDb(It.IsAny<PlatformEntity>()), Times.Once);
    }
    
    [Fact]
    public void PlatformService_UpdatePlatform_UpdatesPlatformEntity()
    {
        //Arrange
        var platformDto = TestUtils.PlatformEntityUtil.CreateUpdatePlatformDto();
        var platform = _platformMapper.Map<UpdatePlatformDto, Platform>(platformDto);
        var platformEntity = _platformMapper.Map<Platform, PlatformEntity>(platform);
        _platformDbServiceMock.Setup(x => x.UpdatePlatformDb(platformEntity));
        
        //Act
        _platformServiceTest.UpdatePlatform(platformDto);
        
        //Assert
        _platformDbServiceMock.Verify(s => s.UpdatePlatformDb(It.IsAny<PlatformEntity>()), Times.Once);
    }
    
    [Fact]
    public void PlatformService_GetAllPlatforms_ReturnsAllPlatformDtos()
    {
        //Arrange
        var platformEntities = TestUtils.PlatformEntityUtil.CreatePlatformEntities();
        _platformDbServiceMock.Setup(x => x.GetAllPlatformsDb()).Returns(platformEntities);
        
        var platforms = _platformMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = _platformMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platforms);
        
        //Act
        var result = _platformServiceTest.GetAllPlatforms();
        
        //Assert
        result.Should().NotBeNull();
        result.Should().BeEquivalentTo(platformDtos);
    }
}