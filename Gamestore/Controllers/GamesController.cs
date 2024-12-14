using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BusinessLogic.Contracts;
#pragma warning disable IDE0005
using DTOs.CommentDtos;
#pragma warning restore IDE0005
using DTOs.GameDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GamesController(
    IGameService gameService,
    ICommentService commentService,
    IGenreService genreService,
    IPlatformService platformService,
    IPublisherService publisherService,
    IDataSeederService dataSeederService) : Controller
{
    [HttpPost]
    [Authorize(Policy = "RequireCreateGamePermission")]
    public IActionResult CreateGame(CreateGameDto createGameDto)
    {
        gameService.CreateGame(createGameDto);

        return Ok();
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetGamesPermission")]
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
    [Authorize(Policy = "RequireUpdateGamePermission")]
    public IActionResult UpdateGame(UpdateGameDto updateGameDto)
    {
        gameService.UpdateGame(updateGameDto);

        return Ok();
    }

    [HttpDelete("{key}")]
    [Authorize(Policy = "RequireDeleteGamePermission")]
    public IActionResult DeleteGame(string key)
    {
        gameService.DeleteGame(key);

        return Ok();
    }

    [HttpGet("{key}")]
    [Authorize(Policy = "RequireGetGameByKeyPermission")]
    public IActionResult GetGameByKey(string key)
    {
        var game = gameService.GetGameByKey(key, true);

        return Ok(game);
    }

    [HttpGet("find/{id}")]
    [Authorize(Policy = "RequireGetGameByIdPermission")]
    public IActionResult GetGameById(Guid id)
    {
        var game = gameService.GetGameById(id);

        return Ok(game);
    }

    [HttpGet("{key}/genres")]
    [Authorize(Policy = "RequireGetGenresOfGamePermission")]
    public IActionResult GetGenresOfGame(string key)
    {
        return Ok(genreService.GetGenresOfGame(key));
    }

    [HttpGet("{key}/platforms")]
    [Authorize(Policy = "RequireGetPlatformsOfGamePermission")]
    public IActionResult GetPlatformsOfGame(string key)
    {
        return Ok(platformService.GetPlatformsOfGame(key));
    }

    [HttpGet("{key}/publisher")]
    [Authorize(Policy = "RequireGetPublisherOfGamePermission")]
    public IActionResult GetPublisherOfGame(string key)
    {
        return Ok(publisherService.GetPublisherOfGame(key));
    }

    [HttpGet("{key}/file")]
    [Authorize(Policy = "RequireDownloadGameFilePermission")]
    public IActionResult DownloadGameFile(string key)
    {
        var game = gameService.GetGameByKey(key);

        var fileName = $"{game.Name}_{DateTime.UtcNow:yyyyMMddHHmmss}.txt";
        var fileContent = JsonConvert.SerializeObject(game);
        var fileBytes = Encoding.UTF8.GetBytes(fileContent);

        return File(fileBytes, "text/plain", fileName);
    }

    [HttpPost("{key}/buy")]
    [Authorize(Policy = "RequireAddGameInCartPermission")]
    public IActionResult AddGameInCart(string key)
    {
        gameService.AddGameInCart(key);
        return Ok();
    }

    [HttpGet("{key}/comments")]
    [Authorize(Policy = "RequireGetCommentsPermission")]
    public IActionResult GetComments(string key)
    {
        return Ok(commentService.GetComments(key));
    }

    [HttpPost("{key}/comments")]
    [Authorize(Policy = "RequireAddCommentPermission")]
    public IActionResult AddComment(string key, AddCommentDto addCommentDto)
    {
        // string action = addCommentDto.Action;
        var token = GetToken();
        var userName = GetNameFromToken(token);
        addCommentDto.Comment.Name = userName;
        commentService.AddComment(key, addCommentDto);
        
        return Ok();
    }

    [HttpDelete("{key}/comments/{id}")]
    [Authorize(Policy = "RequireDeleteCommentPermission")]
    public IActionResult DeleteComment(string key, Guid id)
    {
        commentService.DeleteComment(key, id);
        return Ok();
    }

    [HttpGet("pagination-options")]
    [Authorize(Policy = "RequireGetPaginationOptionsPermission")]
    public IActionResult GetPaginationOptions()
    {
        return Ok(new List<string> { "10", "20", "50", "100", "all" });
    }

    [HttpGet("sorting-options")]
    [Authorize(Policy = "RequireGetSortingOptionsPermission")]
    public IActionResult GetSortingOptions()
    {
        return Ok(new List<string> { "Most popular", "Most commented", "Price ASC", "Price DESC", "New" });
    }

    [HttpGet("all")]
    [Authorize(Policy = "RequireGetAllGamesPermission")]
    public IActionResult GetAllGames()
    {
        return Ok(gameService.GetAllGames());
    }
    
    [HttpPost("Seed/{count:int}/games")]
    public async Task<IActionResult> SeedGames(int count)
    {
        await dataSeederService.SeedGamesAsync(count);
        return Ok();
    }

    private string GetToken()
    {
        var token = HttpContext.Request.Headers["Authorization"].ToString();
        return token.Replace("bearer ", string.Empty);
    }

    private static string GetNameFromToken(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jwtToken = handler.ReadJwtToken(token);

        var nameClaim = jwtToken.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Name);
        return nameClaim?.Value;
    }
}