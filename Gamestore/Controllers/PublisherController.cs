#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PublisherController(IPublisherService publisherService) : Controller
{
    [HttpPost]
    public IActionResult Create(CreatePublisherDto publisherDto)
    {
        publisherService.CreatePublisher(publisherDto);

        return Ok();
    }

    [HttpGet("{companyName}")]
    public IActionResult GetPublisherByCompanyName(string companyName)
    {
        var publisher = publisherService.GetPublisherByCompanyName(companyName);

        return Ok(publisher);
    }

    [HttpGet]
    public IActionResult GetAllPublishers()
    {
        var publishers = publisherService.GetAllPublishers();

        return Ok(publishers);
    }

    [HttpPut]
    public IActionResult UpdatePublisher(UpdatePublisherDto updatePublisherDto)
    {
        publisherService.UpdatePublisher(updatePublisherDto);

        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePublisher(Guid id)
    {
        publisherService.DeletePublisher(id);

        return Ok();
    }

    [HttpGet("{companyName}/games")]
    public IActionResult GetGamesByPublisherName(string companyName)
    {
        var gameDtos = publisherService.GetGamesOfPublisher(companyName);

        return Ok(gameDtos);
    }
}