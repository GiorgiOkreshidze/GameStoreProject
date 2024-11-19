using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class GenreService(IGenreDbService genreDbService,
    IMapper genreMapper) : IGenreService
{
    public void CreateGenre(CreateGenreDto createGenreDto)
    {
        var genre = genreMapper.Map<CreateGenreDto, Genre>(createGenreDto);
        genre.Id = Guid.NewGuid();

        var genreEntity = genreMapper.Map<Genre, GenreEntity>(genre);

        genreDbService.CreateGenreDb(genreEntity);
    }

    public ICollection<GenreDto> GetAllGenres()
    {
        var genreEntities = genreDbService.GetAllGenresDb();

        var genre = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public void UpdateGenre(UpdateGenreDto updateGenreDto)
    {
        var updateGenre = genreMapper.Map<UpdateGenreDto, Genre>(updateGenreDto);
        /*validator.ValidateGenre(updateGenre.Id);
        validator.ValidateGenreName(updateGenre.Name);*/
        var updateGenreEntity = genreMapper.Map<Genre, GenreEntity>(updateGenre);

        genreDbService.UpdateGenreDb(updateGenreEntity);
    }

    public void DeleteGenre(Guid id)
    {
        var genreEntity = genreDbService.GetGenreByGuid(id);
        genreDbService.DeleteGenreDb(genreEntity);
    }

    public GetGenreDto GetGenre(Guid id)
    {
        GenreEntity genreEntity = genreDbService.GetGenreByGuid(id);
        var genre = genreMapper.Map<GenreEntity, Genre>(genreEntity);
        var getGenreDto = genreMapper.Map<Genre, GetGenreDto>(genre);

        return getGenreDto;
    }

    public ICollection<GenreDto> GetSubGenres(Guid id)
    {
        var genreEntities = genreDbService.GetSubGenresDb(id);

        var genre = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }

    public ICollection<GenreDto> GetGenresOfGame(string key)
    {
        /*validator.ValidateGameKey(key);*/
        ICollection<GenreEntity> genreEntities = genreDbService.GetGenresOfGameDb(key);
        /*if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception($"this {key} gameKey not exists");
            }
            else
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                var categorydbId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                var genreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = categorydbId;
                if (genreEntities.All(p => p.Id != categorydbId))
                {
                    genreEntities.Add(genreEntity);
                }
            }
        }
        else
        {
            genreEntities = gameDbService.GetGenresOfGameDb(key);

            if (!productMongoService.KeyNotExists(key))
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                var dbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                var categorydbId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                var genreEntity = gameMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = categorydbId;
                if (genreEntities.All(p => p.Id != categorydbId))
                {
                    genreEntities.Add(genreEntity);
                }
            }
        }*/

        var genres = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genres);

        return genreDtos;
    }
}