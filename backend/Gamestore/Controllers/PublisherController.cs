#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PublisherController(IPublisherService publisherService,
    IGameService gameService) : Controller
{
    [HttpPost]
    [Authorize(Policy = "RequireCreatePublisherPermission")]
    public IActionResult CreatePublisher(CreatePublisherDto publisherDto)
    {
        publisherService.CreatePublisher(publisherDto);

        return Ok();
    }

    [HttpGet("{companyName}")]
    [Authorize(Policy = "RequireGetPublisherByCompanyNamePermission")]
    public IActionResult GetPublisherByCompanyName(string companyName)
    {
        var publisher = publisherService.GetPublisherByCompanyName(companyName);

        return Ok(publisher);
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetAllPublishersPermission")]
    public IActionResult GetAllPublishers()
    {
        var publishers = publisherService.GetAllPublishers();

        return Ok(publishers);
    }

    [HttpPut]
    [Authorize(Policy = "RequireUpdatePublisherPermission")]
    public IActionResult UpdatePublisher(UpdatePublisherDto updatePublisherDto)
    {
        publisherService.UpdatePublisher(updatePublisherDto);

        return Ok();
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "RequireDeletePublisherPermission")]
    public IActionResult DeletePublisher(Guid id)
    {
        publisherService.DeletePublisher(id);

        return Ok();
    }

    [HttpGet("{companyName}/games")]
    [Authorize(Policy = "RequireGetGamesByPublisherNamePermission")]
    public IActionResult GetGamesByPublisherName(string companyName)
    {
        var gameDtos = gameService.GetGamesOfPublisher(companyName);

        return Ok(gameDtos);
    }
}