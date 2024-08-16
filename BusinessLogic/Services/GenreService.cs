using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.GenreDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class GenreService(IGenreDbService genreDbService,
    ICategoryMongoService categoryMongoService,
    IDatabasesSyncDbService databasesSyncDbService,
    IMapper genreMapper, IValidationsHandler validator,
    IProductMongoService productMongoService,
    IPublisherDbService publisherDbService) : IGenreService
{
    public void CreateGenre(CreateGenreDto createGenreDto)
    {
        var genre = genreMapper.Map<CreateGenreDto, Genre>(createGenreDto);
        validator.ValidateGenreName(genre.Name);
        genre.Id = Guid.NewGuid();

        var genreEntity = genreMapper.Map<Genre, GenreEntity>(genre);
        if (genreEntity.ParentGenreId is not null)
        {
            if (genreDbService.NotExists((Guid)genreEntity.ParentGenreId) && databasesSyncDbService.ExistsInIdsSet((Guid)genreEntity.ParentGenreId))
            {
                var mongoId = databasesSyncDbService.GetMongoId((Guid)genreEntity.ParentGenreId);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                var transferedGenreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                transferedGenreEntity.Id = (Guid)genreEntity.ParentGenreId;
                genreDbService.CreateGenreDb(transferedGenreEntity);
            }
        }

        genreDbService.CreateGenreDb(genreEntity);
    }

    public ICollection<GenreDto> GetAllGenres()
    {
        var genreEntities = genreDbService.GetAllGenresDb();
        var categoryDocuments = categoryMongoService.GetAllMongo();

        foreach (var categoryDocument in categoryDocuments)
        {
            var id = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
            var genreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
            genreEntity.Id = id;
            if (genreEntities.All(p => p.Id != id))
            {
                genreEntities.Add(genreEntity);
            }
        }

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

        if (databasesSyncDbService.ExistsInIdsSet(updateGenreEntity.Id) && genreDbService.NotExists(updateGenreEntity.Id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(updateGenreEntity.Id);
            var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
            var transferedGenreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
            transferedGenreEntity.Id = updateGenreEntity.Id;
            genreDbService.CreateGenreDb(transferedGenreEntity);
        }

        genreDbService.UpdateGenreDb(updateGenreEntity);
    }

    public void DeleteGenre(Guid id)
    {
        validator.ValidateGenre(id);
        var genreEntity = genreDbService.GetGenreByGuid(id);
        genreDbService.DeleteGenreDb(genreEntity);
    }

    public GetGenreDto GetGenre(Guid id)
    {
        GenreEntity genreEntity;

        // validator.ValidateGenre(id);
        if (genreDbService.NotExists(id))
        {
            if (databasesSyncDbService.ExistsInIdsSet(id))
            {
                var mongoId = databasesSyncDbService.GetMongoId(id);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                genreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = id;
            }
            else
            {
                throw new Exception("Id doesn't exists");
            }
        }
        else
        {
            genreEntity = genreDbService.GetGenreByGuid(id);
        }

        var genre = genreMapper.Map<GenreEntity, Genre>(genreEntity);
        var getGenreDto = genreMapper.Map<Genre, GetGenreDto>(genre);

        return getGenreDto;
    }

    public ICollection<GetGameDto> GetGamesByGenreId(Guid id)
    {
        /*validator.ValidateGenre(id);*/
        ICollection<GameEntity> gameEntities = [];
        if (genreDbService.NotExists(id))
        {
            if (databasesSyncDbService.ExistsInIdsSet(id))
            {
                var mongoId = databasesSyncDbService.GetMongoId(id);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                var productDocuments = categoryMongoService.GetProductsByCategoryId(categoryDocument.CategoryID);
                foreach (var productDocument in productDocuments)
                {
                    var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);
                    var supplierId = databasesSyncDbService.TransferMongoIdToDb(supplierDocument.Id);
                    PublisherEntity publisherEntity;
                    if (publisherDbService.PublisherNotExists(supplierId))
                    {
                        publisherEntity = genreMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                        publisherEntity.Id = supplierId;
                    }
                    else
                    {
                        publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(supplierDocument.CompanyName);
                    }

                    GenreEntity genreEntity;
                    if (genreDbService.NotExists(id))
                    {
                        genreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                        genreEntity.Id = id;
                    }
                    else
                    {
                        genreEntity = genreDbService.GetGenreByGuid(id);
                    }

                    var productId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                    var gameEntity = genreMapper.Map<ProductDocument, GameEntity>(productDocument);
                    gameEntity.Id = productId;
                    gameEntity.PublisherEntity = publisherEntity;
                    gameEntity.PublisherId = publisherEntity.Id;
                    gameEntity.GenreEntities = [genreEntity];
                    if (gameEntities.All(p => p.Id != productId))
                    {
                        gameEntities.Add(gameEntity);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("company Name Not exists in MongoDb");
            }
        }
        else
        {
            gameEntities = genreDbService.GetGamesByGenreId(id);

            if (databasesSyncDbService.ExistsInIdsSet(id))
            {
                var mongoId = databasesSyncDbService.GetMongoId(id);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                var productDocuments = categoryMongoService.GetProductsByCategoryId(categoryDocument.CategoryID);
                foreach (var productDocument in productDocuments)
                {
                    var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);
                    var supplierId = databasesSyncDbService.TransferMongoIdToDb(supplierDocument.Id);
                    PublisherEntity publisherEntity;
                    if (publisherDbService.PublisherNotExists(supplierId))
                    {
                        publisherEntity = genreMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                        publisherEntity.Id = supplierId;
                    }
                    else
                    {
                        publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(supplierDocument.CompanyName);
                    }

                    GenreEntity genreEntity;
                    if (genreDbService.NotExists(id))
                    {
                        genreEntity = genreMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                        genreEntity.Id = id;
                    }
                    else
                    {
                        genreEntity = genreDbService.GetGenreByGuid(id);
                    }

                    var productId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                    var gameEntity = genreMapper.Map<ProductDocument, GameEntity>(productDocument);
                    gameEntity.Id = productId;
                    gameEntity.PublisherEntity = publisherEntity;
                    gameEntity.PublisherId = publisherEntity.Id;
                    gameEntity.GenreEntities = [genreEntity];
                    if (gameEntities.All(p => p.Id != productId))
                    {
                        gameEntities.Add(gameEntity);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("company Name Not exists in MongoDb");
            }
        }

        var game = genreMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = genreMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(game);

        return gameDtos;
    }

    public ICollection<GenreDto> GetSubGenres(Guid id)
    {
        validator.ValidateGenre(id);
        var genreEntities = genreDbService.GetSubGenresDb(id);

        var genre = genreMapper.Map<ICollection<GenreEntity>, ICollection<Genre>>(genreEntities);
        var genreDtos = genreMapper.Map<ICollection<Genre>, ICollection<GenreDto>>(genre);

        return genreDtos;
    }
}