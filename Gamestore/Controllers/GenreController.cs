using BusinessLogic.Contracts;
using BusinessLogic.Services;
using DTOs.GameDtos;
using DTOs.GenreDtos;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController : Controller
{
    public readonly IGenreService GenreService;
    
    public GenreController(IGenreService genreService)
    {
        GenreService = genreService;
    }

    [HttpPost]
    public IActionResult CreateGenre(CreateGenreDto createGenreDto)
    {
        GenreService.CreateGenre(createGenreDto);

        return Ok();
    }

    [HttpGet]
    public ICollection<GenreDto> GetAllGenres()
    {
        return GenreService.GetAllGenres();
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
    public GetGenreDto GetGenre(Guid id)
    {
        return GenreService.GetGenre(id);
    }
    
    [HttpGet("{id}/games")]
    public ICollection<GetGameDto> GetGamesByGerneId(Guid id)
    {
        var gameDtos = GenreService.GetGamesByGenreId(id);
        
        return gameDtos;
    }
    
    [HttpGet("{id}/genres")]
    public ICollection<GenreDto> GetSubGenres(Guid id)
    {
        return GenreService.GetSubGenres(id);
    }
}