using DataAccess.Contracts;
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Validations;

public class GenreValidator(IHttpContextAccessor httpContextAccessor, IGenreDbService genreDbService, IGameDbService gameDbService) : Validator(httpContextAccessor)
{
    public void CanCreateGenre(string genreName)
    {
        if (genreDbService.NameExists(genreName))
        {
            throw new UnauthorizedAccessException("You can't create new genre");
        }
    }

    public void CanUpdateGenre(Guid genreId)
    {
        _ = genreDbService.GetGenreByGuid(genreId) ?? throw new ArgumentException("Genre with given ID does not exist");
    }

    public void CanDeleteGenre(Guid genreId)
    {
        _ = genreDbService.GetGenreByGuid(genreId) ?? throw new ArgumentException("Genre with given ID does not exist");
    }

    public void CanGetGenresByGameId(Guid gameId)
    {
        _ = gameDbService.GetGameByIdDb(gameId) ?? throw new ArgumentException("Game with given ID does not exist");
    }
}