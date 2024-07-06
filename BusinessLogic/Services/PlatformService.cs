using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Exceptions;
using BusinessLogic.Models;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PlatformDtos;

namespace BusinessLogic.Services;

public class PlatformService(IPlatformDbService platformDbService, IMapper platformMapper)
    : IPlatformService
{
    public void CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        var platform = platformMapper.Map<CreatePlatformDto, Platform>(createPlatformDto);

        platform.Id = Guid.NewGuid();

        ValidatePlatformType(platform.Type);

        var platformEntity = platformMapper.Map<Platform, PlatformEntity>(platform);

        platformDbService.CreatePlatformDb(platformEntity);
    }

    public ICollection<PlatformDto> GetAllPlatforms()
    {
        var platformEntities = platformDbService.GetAllPlatformsDb();

        var platform = platformMapper.Map<ICollection<PlatformEntity>, ICollection<Platform>>(platformEntities);
        var platformDtos = platformMapper.Map<ICollection<Platform>, ICollection<PlatformDto>>(platform);

        return platformDtos;
    }

    public void UpdatePlatform(UpdatePlatformDto updatePlatformDto)
    {
        var platform = platformMapper.Map<UpdatePlatformDto, Platform>(updatePlatformDto);
        ValidatePlatform(platform.Id);
        ValidatePlatformType(platform.Type);
        var platformEntity = platformMapper.Map<Platform, PlatformEntity>(platform);

        platformDbService.UpdatePlatformDb(platformEntity);
    }

    public void DeletePlatform(Guid id)
    {
        ValidatePlatform(id);
        var entity = platformDbService.GetPlatformByGuid(id);
        platformDbService.DeletePlatformDb(entity);
    }

    public PlatformDto GetPlatformById(Guid id)
    {
        ValidatePlatform(id);
        var platformEntity = platformDbService.GetPlatformByGuid(id);

        var platform = platformMapper.Map<PlatformEntity, Platform>(platformEntity);
        var platformDto = platformMapper.Map<Platform, PlatformDto>(platform);

        return platformDto;
    }

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id)
    {
        ValidatePlatform(id);
        var gameEntities = platformDbService.GetGamesByPlatformId(id);
        
        var game = platformMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = platformMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);
        
        return gameDtos;
    }
    
    private void ValidatePlatform(Guid id)
    {
        if (platformDbService.NotExists(id))
        {
            throw new PlatformNotExistsException("Platform with platformId not exists");
        }
    }
    
    private void ValidatePlatformType(string name)
    {
        if (platformDbService.TypeExists(name))
        {
            throw new PlatformTypeExistsException("Platform with this type already exists");
        }
    }
    
    
}