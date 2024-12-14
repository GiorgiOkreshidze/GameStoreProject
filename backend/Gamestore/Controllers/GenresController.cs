#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.GenreDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GenresController(IGenreService genreService,
    IGameService gameService) : Controller
{
    [HttpPost]
    [Authorize(Policy = "RequireCreateGenrePermission")]
    public IActionResult CreateGenre(CreateGenreDto createGenreDto)
    {
        genreService.CreateGenre(createGenreDto);

        return Ok();
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetAllGenresPermission")]
    public IActionResult GetAllGenres()
    {
        return Ok(genreService.GetAllGenres());
    }

    [HttpPut]
    [Authorize(Policy = "RequireUpdateGenrePermission")]
    public IActionResult UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        genreService.UpdateGenre(updateGenreDto);
        return Ok();
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "RequireDeleteGenrePermission")]
    public IActionResult DeleteGenre(Guid id)
    {
        genreService.DeleteGenre(id);
        return Ok();
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGetGenrePermission")]
    public IActionResult GetGenre(Guid id)
    {
        return Ok(genreService.GetGenre(id));
    }

    [HttpGet("{id}/games")]
    [Authorize(Policy = "RequireGetGamesByGenreIdPermission")]
    public IActionResult GetGamesByGerneId(Guid id)
    {
        var gameDtos = gameService.GetGamesByGenreId(id);

        return Ok(gameDtos);
    }

    [HttpGet("{id}/genres")]
    [Authorize(Policy = "RequireGetSubGenresPermission")]
    public IActionResult GetSubGenres(Guid id)
    {
        return Ok(genreService.GetSubGenres(id));
    }
}