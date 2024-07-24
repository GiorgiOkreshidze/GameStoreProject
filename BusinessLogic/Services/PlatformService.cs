using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PlatformDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class PlatformService(IPlatformDbService platformDbService, IMapper platformMapper, IValidationsHandler validator)
    : IPlatformService
{
    public void CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        var platform = platformMapper.Map<PlatformDtoWithoutId, Platform>(createPlatformDto.Platform);

        platform.Id = Guid.NewGuid();

        validator.ValidatePlatformType(platform.Type);

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
        validator.ValidatePlatform(platform.Id);
        validator.ValidatePlatformType(platform.Type);
        var platformEntity = platformMapper.Map<Platform, PlatformEntity>(platform);

        platformDbService.UpdatePlatformDb(platformEntity);
    }

    public void DeletePlatform(Guid id)
    {
        validator.ValidatePlatform(id);
        var entity = platformDbService.GetPlatformByGuid(id);
        platformDbService.DeletePlatformDb(entity);
    }

    public PlatformDto GetPlatformById(Guid id)
    {
        validator.ValidatePlatform(id);
        var platformEntity = platformDbService.GetPlatformByGuid(id);

        var platform = platformMapper.Map<PlatformEntity, Platform>(platformEntity);
        var platformDto = platformMapper.Map<Platform, PlatformDto>(platform);

        return platformDto;
    }

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id)
    {
        validator.ValidatePlatform(id);
        var gameEntities = platformDbService.GetGamesByPlatformId(id);

        var game = platformMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = platformMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);

        return gameDtos;
    }
}