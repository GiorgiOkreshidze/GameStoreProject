using BusinessLogic.Contracts;
using DTOs.PlatformDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PlatformsController(IPlatformService platformService,
    IGameService gameService) : Controller
{
    [HttpPost]
    [Authorize(Policy = "RequireCreatePlatformPermission")]
    public IActionResult CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        platformService.CreatePlatform(createPlatformDto);
        return Ok();
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetAllPlatformsPermission")]
    public IActionResult GetAllPlatforms()
    {
        return Ok(platformService.GetAllPlatforms());
    }

    [HttpPut]
    [Authorize(Policy = "RequireUpdatePlatformPermission")]
    public IActionResult UpdatePlatform(UpdatePlatformDto updatePlatformDto)
    {
        platformService.UpdatePlatform(updatePlatformDto);

        return Ok();
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "RequireDeletePlatformPermission")]
    public IActionResult DeletePlatform(Guid id)
    {
        platformService.DeletePlatform(id);
        return Ok();
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGetPlatformByIdPermission")]
    public IActionResult GetPlatformById(Guid id)
    {
        return Ok(platformService.GetPlatformById(id));
    }

    [HttpGet("{id}/games")]
    [Authorize(Policy = "RequireGetGamesByPlatformIdPermission")]
    public IActionResult GetGamesByPlatformId(Guid id)
    {
        var gameDtos = gameService.GetGamesByPlatformId(id);

        return Ok(gameDtos);
    }
}