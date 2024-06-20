using DataAccess.Entities;

namespace DataAccess.Interface;

public interface IGenreDbService
{
    public GenreEntity getGenreByGiud(Guid guid);
}