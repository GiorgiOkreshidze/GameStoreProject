using BusinessLogic.Models;
using BusinessLogic.Services;
using Gamestore.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : Controller
{
    public readonly IGameService _gameService;

    public GameController(IGameService gameService)
    {
        _gameService = gameService;
    }
      
    [HttpPost]
    public IActionResult Create(CreateGameDto createGameDto)
    {
        _gameService.createGame(createGameDto);

        return Ok();
    }
    
    [HttpGet]
    public GetGameDto Read()
    {
        var game = _gameService.getGame();
        
        return game;
    }
    
    
    
    
    // I need to change the endpoint URL
    /*[HttpGet]
    public GetGameDto ReadByKey(string key)
    {
        var game = _gameService.getGameByKey(key);
        
        return game;
    }*/
}