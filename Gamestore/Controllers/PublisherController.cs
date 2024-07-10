using BusinessLogic.Contracts;
using DataAccess.Entities;
using DTOs.PublisherDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class PublisherController (IPublisherService publisherService) : Controller
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