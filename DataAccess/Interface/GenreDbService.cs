using Azure.Core;
using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Interface;

public class GenreDbService : IGenreDbService
{
    private GameDbContext _gameDbContext;
    
    public GenreDbService(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
    
    public GenreEntity getGenreByGiud(Guid guid)
    { 
        return _gameDbContext.Set<GenreEntity>().Where(g => g.Id == guid).FirstOrDefault();
    }
}