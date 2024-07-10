using BusinessLogic.Exceptions;
using BusinessLogic.Models;
using DataAccess.Contracts;

namespace BusinessLogic.Validations;

public class ValidationsHandler( IGameDbService gameDbService, IGenreDbService genreDbService, IPlatformDbService platformDbService, 
    IPublisherDbService publisherDbService) : IValidationsHandler
{
    public void ValidateGenres(ICollection<Guid> genreIds)
    {
        foreach (var genreId in genreIds)
        {
            if (genreDbService.NotExists(genreId))
            {
                throw new GenreNotExistsException("Genre with genreId not exists");
            }
        }
    }

    public void ValidatePlatforms(ICollection<Guid> platfomrIds)
    {
        foreach (var platformId in platfomrIds)
        {
            if (platformDbService.NotExists(platformId))
            {
                throw new PlatformNotExistsException("Platform with platformId not exists");
            }
        }
    }
    
    public void ValidateGameId(Guid id)
    {
        if (gameDbService.NotExists(id))
        {
            throw new GameNotExistsException("Game not exists");
        }
    }

    public void ValidateGameKey(string key)
    {
        if (gameDbService.KeyNotExists(key))
        {
            throw new KeyNotFoundException();
        }
    }

    public void ValidatePublisherId(Guid? id)
    {
        if (publisherDbService.PublisherNotExists(id))
        {
            throw new PublisherNotExistsException("Publisher with that Id doesn't exists");
        }
    }
    
    public void ValidatePlatform(Guid id)
    {
        if (platformDbService.NotExists(id))
        {
            throw new PlatformNotExistsException("Platform with platformId not exists");
        }
    }
    
    public void ValidatePlatformType(string type)
    {
        if (platformDbService.TypeExists(type))
        {
            throw new PlatformTypeExistsException("Platform with this type already exists");
        }
    }

    public void ValidateGenre(Guid id)
    {
        if (genreDbService.NotExists(id))
        {
            throw new GenreNotExistsException("Genre with genreId not exists");
        }
    }

    public void ValidateGenreName(string name)
    {
        if (genreDbService.NameExists(name))
        {
            throw new GenreNameExistsException("Genre with this name already exists");
        }
    }

    public void ValidateCompanyName(string companyName)
    {
        if (publisherDbService.CompanyNameNotExists(companyName))
        {
            throw new Exception("CompanyName Not Exists");
        }
    }

}