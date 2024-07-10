using DTOs.GameDtos;
using DTOs.PlatformDtos;

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