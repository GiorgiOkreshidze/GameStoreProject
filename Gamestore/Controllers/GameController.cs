using System.Text;
#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.GameDtos;
#pragma warning restore IDE0005
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
    public IActionResult Read()
    {
        var games = gameService.GetAllGames();

        return Ok(games);
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
    public IActionResult GetGameByKey(string key)
    {
        var game = gameService.GetGameByKey(key);

        return Ok(game);
    }

    [HttpGet("find/{id}")]
    public IActionResult GetGameById(Guid id)
    {
        var game = gameService.GetGameById(id);

        return Ok(game);
    }

    [HttpGet("{key}/genres")]
    public IActionResult GetGenresOfGame(string key)
    {
        return Ok(gameService.GetGenresOfGame(key));
    }

    [HttpGet("{key}/platforms")]
    public IActionResult GetPlatformsOfGame(string key)
    {
        return Ok(gameService.GetPlatformsOfGame(key));
    }

    [HttpGet("{key}/publisher")]
    public IActionResult GetPublisherOfGame(string key)
    {
        return Ok(gameService.GetPublisherOfGame(key));
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