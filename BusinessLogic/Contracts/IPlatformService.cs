#pragma warning disable IDE0005
using DTOs.GameDtos;
using DTOs.PlatformDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IPlatformService
{
    public void CreatePlatform(CreatePlatformDto createPlatformDto);

    public ICollection<PlatformDto> GetAllPlatforms();

    public void UpdatePlatform(UpdatePlatformDto updatePlatformDto);

    public void DeletePlatform(Guid id);

    public PlatformDto GetPlatformById(Guid id);

    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id);
}