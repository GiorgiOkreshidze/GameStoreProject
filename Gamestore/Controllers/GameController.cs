using System.Text;
using BusinessLogic.Contracts;
#pragma warning disable IDE0005
using DTOs.CommentDtos;
#pragma warning restore IDE0005
using DTOs.GameDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
    public IActionResult GetGames([FromQuery] GameFilterDto filter)
    {
        return Ok(gameService.GetGames(
            filter,
            new GameSortDto { Sort = filter.Sort },
            new GamePaginationDto
            {
                PageNumber = filter.Page,
                PageSize = filter.PageCount,
            }));
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
        var fileContent = JsonConvert.SerializeObject(game);
        var fileBytes = Encoding.UTF8.GetBytes(fileContent);

        return File(fileBytes, "text/plain", fileName);
    }

    [HttpPost("{key}/buy")]
    public IActionResult AddGameInCart(string key)
    {
        gameService.AddGameInCart(key);
        return Ok();
    }

    [HttpGet("{key}/comments")]
    public IActionResult GetComments(string key)
    {
        return Ok(gameService.GetComments(key));
    }

    [HttpPost("{key}/comments")]
    public IActionResult AddComment(string key, AddCommentDto addCommentDto)
    {
        string action = addCommentDto.Action;
        if (action == "Quote")
        {
            gameService.AddCommentAsQuote(key, addCommentDto);
        }
        else if (action == "Reply")
        {
            gameService.AddCommentAsReply(key, addCommentDto);
        }
        else
        {
            gameService.AddComment(key, addCommentDto);
        }

        return Ok();
    }

    [HttpDelete("{key}/comments/{id}")]
    public IActionResult DeleteComment(string key, Guid id)
    {
        gameService.DeleteComment(key, id);
        return Ok();
    }

    [HttpGet("pagination-options")]
    public IActionResult GetPaginationOptions()
    {
        return Ok(new List<string> { "10", "20", "50", "100", "all" });
    }

    [HttpGet("sorting-options")]
    public IActionResult GetSortingOptions()
    {
        return Ok(new List<string> { "Most popular", "Most commented", "Price ASC", "Price DESC", "New" });
    }
}