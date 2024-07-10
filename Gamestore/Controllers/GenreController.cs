using BusinessLogic.Contracts;
using DTOs.GenreDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController(IGenreService genreService) : Controller
{
    [HttpPost]
    public IActionResult CreateGenre(CreateGenreDto createGenreDto)
    {
        genreService.CreateGenre(createGenreDto);

        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllGenres()
    {
        return Ok(genreService.GetAllGenres());
    }

    [HttpPut]
    public IActionResult UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        genreService.UpdateGenre(updateGenreDto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteGenre(Guid id)
    {
        genreService.DeleteGenre(id);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetGenre(Guid id)
    {
        return Ok(genreService.GetGenre(id));
    }

    [HttpGet("{id}/games")]
    public IActionResult GetGamesByGerneId(Guid id)
    {
        var gameDtos = genreService.GetGamesByGenreId(id);

        return Ok(gameDtos);
    }

    [HttpGet("{id}/genres")]
    public IActionResult GetSubGenres(Guid id)
    {
        return Ok(genreService.GetSubGenres(id));
    }
}