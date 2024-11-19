using AutoMapper;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.StoreIntegrationContracts;
using DataAccess.ValueObjects;
using Microsoft.IdentityModel.Tokens;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace DataAccess.StoreIntegrationServices;

public class GenreServiceDecorator(IGenreDbService genreDbService,
    ICategoryMongoService categoryMongoService,
    IMapper mapper,
    IDatabasesSyncDbService databasesSyncDbService) : IGenreDbService, IGenreServiceDecorator
{
    public void CreateGenreDb(GenreEntity genreEntity)
    {
        if (genreEntity.ParentGenreId is not null)
        {
            if (genreDbService.NotExists((Guid)genreEntity.ParentGenreId) &&
                databasesSyncDbService.ExistsInIdsSet((Guid)genreEntity.ParentGenreId))
            {
                var mongoId = databasesSyncDbService.GetMongoId((Guid)genreEntity.ParentGenreId);
                var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
                var transferedGenreEntity = mapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                transferedGenreEntity.Id = (Guid)genreEntity.ParentGenreId;
                genreDbService.CreateGenreDb(transferedGenreEntity);
            }
        }

        genreDbService.CreateGenreDb(genreEntity);
    }

    public GenreEntity GetGenreByGuid(Guid id)
    {
        GenreEntity genreEntity = genreDbService.GetGenreByGuid(id);

        if (genreEntity == null && databasesSyncDbService.CanSyncObject(id))
        {
            var genreId = databasesSyncDbService.GetMongoId(id);
            var categoryDocument = categoryMongoService.GetCategoryByIdMongo(genreId);
            if (!categoryDocument.Id.IsNullOrEmpty())
            {
                genreEntity = mapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                genreEntity.Id = id;
            }
        }

        return genreEntity;
    }

    public ICollection<GenreEntity> GetAllGenresDb()
    {
        var genres = genreDbService.GetAllGenresDb();

        ICollection<string> collection = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Genre);

        var genresMongo = categoryMongoService.GetAllMongoFiltered(collection);

        foreach (var genre in genresMongo)
        {
            var genreEntity = mapper.Map<CategoryDocument, GenreEntity>(genre);
            genreEntity.Id = databasesSyncDbService.TransferMongoIdToDb(genre.Id);
            genres.Add(genreEntity);
        }

        return genres;
    }

    public void UpdateGenreDb(GenreEntity updateGenreEntity)
    {
        TransferCategoryToDatabase(updateGenreEntity.Id);
        genreDbService.UpdateGenreDb(updateGenreEntity);
    }

    public void DeleteGenreDb(GenreEntity genreEntity)
    {
        if (!databasesSyncDbService.CanSyncObject(genreEntity.Id))
        {
            databasesSyncDbService.MarkObjectAsSynced(genreEntity.Id);
        }
        else
        {
            genreDbService.DeleteGenreDb(genreEntity);
        }
    }

    public ICollection<GenreEntity> GetSubGenresDb(Guid id)
    {
        return genreDbService.GetSubGenresDb(id);
    }

    public bool NotExists(Guid id)
    {
        bool notExists = genreDbService.NotExists(id);

        if (notExists)
        {
            notExists = !databasesSyncDbService.CanSyncObject(id);
        }

        return notExists;
    }

    public bool NameExists(string name)
    {
        return genreDbService.NameExists(name);
    }

    public ICollection<GenreEntity> GetGenresOfGameDb(string key)
    {
        var genres = genreDbService.GetGenresOfGameDb(key);

        if (genres.IsNullOrEmpty())
        {
            CategoryDocument document = categoryMongoService.GetCategoryByProductKey(key);

            if (document != null)
            {
                var genreEntity = mapper.Map<CategoryDocument, GenreEntity>(document);
                var genreGuid = databasesSyncDbService.TransferMongoIdToDb(document.Id);
                genreEntity.Id = genreGuid;
                if (databasesSyncDbService.CanSyncObject(genreEntity.Id))
                {
                    genres.Add(genreEntity);
                }
            }
        }

        return genres;
    }

    public GenreEntity GetGenreByMongoId(int categoryId)
    {
        CategoryDocument categoryDocument = categoryMongoService.GetCategoryByCategoryId(categoryId);
        Guid genreId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
        return !databasesSyncDbService.CanSyncObject(genreId) ? null : GetGenreByGuid(genreId);
    }

    public void TransferCategoryToDatabase(Guid id)
    {
        if (databasesSyncDbService.CanSyncObject(id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(id);
            var categoryDocument = categoryMongoService.GetCategoryByIdMongo(mongoId);
            var transferedGenreEntity = mapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
            transferedGenreEntity.Id = id;
            genreDbService.CreateGenreDb(transferedGenreEntity);
            databasesSyncDbService.MarkObjectAsSynced(id);
        }
    }

    public void TransferCategoryToDatabase(GenreEntity genreEntity)
    {
        if (databasesSyncDbService.CanSyncObject(genreEntity.Id))
        {
            genreDbService.CreateGenreDb(genreEntity);
            databasesSyncDbService.MarkObjectAsSynced(genreEntity.Id);
        }
    }
}