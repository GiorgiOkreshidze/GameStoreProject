using BusinessLogic.Contracts;
using DTOs.GenreDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController(IGenreService genreService) : Controller
{
    public readonly IGenreService GenreService = genreService;

    [HttpPost]
    public IActionResult CreateGenre(CreateGenreDto createGenreDto)
    {
        GenreService.CreateGenre(createGenreDto);

        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllGenres()
    {
        return Ok(GenreService.GetAllGenres());
    }

    [HttpPut]
    public IActionResult UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        GenreService.UpdateGenre(updateGenreDto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteGenre(Guid id)
    {
        GenreService.DeleteGenre(id);
        return Ok();
    }


    [HttpGet("{id}")]
    public IActionResult GetGenre(Guid id)
    {
        return Ok(GenreService.GetGenre(id));
    }
    
    [HttpGet("{id}/games")]
    public IActionResult GetGamesByGerneId(Guid id)
    {
        var gameDtos = GenreService.GetGamesByGenreId(id);
        
        return Ok(gameDtos);
    }
    
    [HttpGet("{id}/genres")]
    public IActionResult GetSubGenres(Guid id)
    {
        return Ok(GenreService.GetSubGenres(id));
    }
}