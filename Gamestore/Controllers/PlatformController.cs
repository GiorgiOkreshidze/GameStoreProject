using System.Collections;
using BusinessLogic.Contracts;
using BusinessLogic.Services;
using DTOs.GameDtos;
using DTOs.PlatformDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PlatformController : Controller
{
    public readonly IPlatformService PlatformService;
    
    public PlatformController(IPlatformService platformService)
    {
        PlatformService = platformService;
    }

    [HttpPost]
    public IActionResult CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        PlatformService.CreatePlatform(createPlatformDto);
        return Ok();
    }

    [HttpGet]
    public ICollection<PlatformDto> GetAllPlatforms()
    {
        return PlatformService.GetAllPlatforms();
    }

    [HttpPut]
    public IActionResult UpdatePlatform(UpdatePlatformDto updatePlatformDto)
    {
        PlatformService.UpdatePlatform(updatePlatformDto);
        
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePlatform(Guid id)
    {
        PlatformService.DeletePlatform(id);
        return Ok();
    }

    [HttpGet("{id}")]
    public PlatformDto GetPlatformById(Guid id)
    {
        return PlatformService.GetPlatformById(id);
    }
    
    
    [HttpGet("{id}/games")]
    public ICollection<GetGameDto> GetGamesByPlatformId(Guid id)
    {
        var gameDtos = PlatformService.GetGamesByPlatformId(id);
        
        return gameDtos;
    }
}