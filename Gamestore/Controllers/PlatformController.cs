using BusinessLogic.Contracts;
using DTOs.PlatformDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PlatformController(IPlatformService platformService) : Controller
{
    [HttpPost]
    public IActionResult CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        platformService.CreatePlatform(createPlatformDto);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllPlatforms()
    {
        return Ok(platformService.GetAllPlatforms());
    }

    [HttpPut]
    public IActionResult UpdatePlatform(UpdatePlatformDto updatePlatformDto)
    {
        platformService.UpdatePlatform(updatePlatformDto);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePlatform(Guid id)
    {
        platformService.DeletePlatform(id);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetPlatformById(Guid id)
    {
        return Ok(platformService.GetPlatformById(id));
    }

    [HttpGet("{id}/games")]
    public IActionResult GetGamesByPlatformId(Guid id)
    {
        var gameDtos = platformService.GetGamesByPlatformId(id);

        return Ok(gameDtos);
    }
}