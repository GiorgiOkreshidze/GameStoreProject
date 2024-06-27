using System.Collections;
using System.IO.Enumeration;
using System.Text;
using System.Text.Json.Serialization;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Services;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using DTOs.PlatformDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController(IGameService gameService) : Controller
{
    [HttpPost]
    public IActionResult Create(CreateGameDto createGameDto)
    {
        gameService.CreateGame(createGameDto);

        return Ok();
    }
    
    [HttpGet]
    public ICollection<GetGameDto> Read()
    {
        var games = gameService.GetAllGames();
        
        return games;
    }
    
    [HttpPut]
    public IActionResult Update(UpdateGameDto updateGameDto)
    {
        gameService.UpdateGame(updateGameDto);
        
        return Ok();
    }

    [HttpDelete("{key}")]
    public IActionResult Delete(string key)
    {
        gameService.DeleteGame(key);

        return Ok();
    }
    

    [HttpGet("{key}")]
    public GetGameDto GetGameByKey(string key)
    {
        var game = gameService.GetGameByKey(key);
        
        return game;
    }
    
    [HttpGet("find/{id}")]
    public GetGameDto GetGameById(Guid id)
    {
        var game = gameService.GetGameById(id);
        
        return game;
    }

    [HttpGet("{key}/genres")]
    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        return gameService.GetGenresOfGame(key);
    }

    [HttpGet("{key}/platforms")]
    public ICollection<PlatformDto> GetPlatformsOfGame(string key)
    {
        return gameService.GetPlatformsOfGame(key);
    }

    [HttpGet("{key}/file")]
    public IActionResult DownloadGameFile(string key)
    {
        var game = gameService.GetGameByKey(key);

        var fileName = $"{game.Name}_{DateTime.UtcNow:yyyyMMddHHmmss}.txt";
        var fileContent = Newtonsoft.Json.JsonConvert.SerializeObject(game);
        var fileBytes = Encoding.UTF8.GetBytes(fileContent);

        return File(fileBytes, "text/plain", fileName);
    }
    
}