using DataAccess.Contracts;
using Microsoft.AspNetCore.Http;

#pragma warning disable IDE0270
namespace BusinessLogic.Validations;

public class PlatformValidation(IHttpContextAccessor httpContextAccessor,
    IPlatformDbService platformDbService) : Validator(httpContextAccessor)
{
    public void CanAccessPlatform(Guid platformId)
    {
        var platform = platformDbService.GetPlatformByGuid(platformId);

        if (platform == null)
        {
            throw new InvalidDataException("Platform Does Not Exist");
        }
    }

    public void CanUpdatePlatform(Guid platformId)
    {
        var platform = platformDbService.GetPlatformByGuid(platformId);

        if (platform == null)
        {
            throw new InvalidDataException("Platform Does Not Exist");
        }
    }

    public void CanDeletePlatform(Guid platformId)
    {
        var platform = platformDbService.GetPlatformByGuid(platformId);

        if (platform == null)
        {
            throw new InvalidDataException("Platform Does Not Exist");
        }
    }

    public void CanAddPlatform(string platformName)
    {
        if (platformDbService.PlatformNameExistsDb(platformName))
        {
            throw new InvalidDataException("Platform Name Already Exists");
        }
    }
}