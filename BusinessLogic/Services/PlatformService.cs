using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.Services;

public class PlatformService : IPlatformService
{
    private readonly IMapper _platformMapper;
    private readonly IPlatformDbService _platformDbService;

    public PlatformService(IPlatformDbService platformDbService, IMapper platformMapper)
    {
        _platformDbService = platformDbService;
        _platformMapper = platformMapper;
    }

    public void CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        var platform = _platformMapper.Map<CreatePlatformDto, Platform>(createPlatformDto);

        platform.Id = Guid.NewGuid();

        var platformEntity = _platformMapper.Map<Platform, PlatformEntity>(platform);

        _platformDbService.CreatePlatformDb(platformEntity);
    }

    public ICollection<PlatformDto> GetAllPlatforms()
    {
        var platformEntities = _platformDbService.GetAllPlatformsDb();

        var platform = _platformMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = _platformMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);

        return platformDtos;
    }

    public void UpdatePlatform(UpdatePlatformDto updatePlatformDto)
    {
        var platform = _platformMapper.Map<UpdatePlatformDto, Platform>(updatePlatformDto);
        var platformEntity = _platformMapper.Map<Platform, PlatformEntity>(platform);

        _platformDbService.UpdatePlatformDb(platformEntity);

    }

    public void DeletePlatform(Guid id)
    {
        _platformDbService.DeletePlatformDb(id);
    }

    public PlatformDto GetPlatformById(Guid id)
    {
        var platformEntity = _platformDbService.GetPlatformByGuid(id);

        var platform = _platformMapper.Map<PlatformEntity, Platform>(platformEntity);
        var platformDto = _platformMapper.Map<Platform, PlatformDto>(platform);

        return platformDto;
    }

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id)
    {
        var gameEntities = _platformDbService.GetGamesByPlatformId(id);
        
        var game = _platformMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = _platformMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);
        
        return gameDtos;
    }
}