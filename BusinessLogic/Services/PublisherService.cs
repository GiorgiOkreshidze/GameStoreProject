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
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class PublisherService(IPublisherDbService publisherDbService,
    ISupplierMongoService supplierMongoService,
    IDatabasesSyncDbService databasesSyncDbService,
    IMapper publisherMapper, IValidationsHandler validator,
    IProductMongoService productMongoService,
    IGenreDbService genreDbService) : IPublisherService
{
    public void CreatePublisher(CreatePublisherDto publisherDto)
    {
        var publisher = publisherMapper.Map<CreatePublisherDto, Publisher>(publisherDto);

        publisher.Id = Guid.NewGuid();

        var publisherEntity = publisherMapper.Map<Publisher, PublisherEntity>(publisher);

        publisherDbService.CreatePublisherDb(publisherEntity);
    }

    public GetPublisherDto GetPublisherByCompanyName(string companyName)
    {
        PublisherEntity publisherEntity;
        if (publisherDbService.CompanyNameNotExists(companyName))
        {
            if (!supplierMongoService.CompanyNameNotExists(companyName))
            {
                var document = supplierMongoService.GetSupplierByCompanyName(companyName);
                var id = databasesSyncDbService.TransferMongoIdToDb(document.Id);
                publisherEntity = publisherMapper.Map<SupplierDocument, PublisherEntity>(document);
                publisherEntity.Id = id;
            }
            else
            {
                throw new InvalidOperationException("company Name Not exists in MongoDb");
            }
        }
        else
        {
            publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(companyName);
        }

        var publisher = publisherMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = publisherMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }

    public ICollection<GetPublisherDto> GetAllPublishers()
    {
        var publisherEntities = publisherDbService.GetAllPublishersDb();
        var supplierDocuments = supplierMongoService.GetAllSuppliersMongo();

        foreach (var supplierDocument in supplierDocuments)
        {
            var id = databasesSyncDbService.TransferMongoIdToDb(supplierDocument.Id);
            var publisherEntity = publisherMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
            publisherEntity.Id = id;
            if (publisherEntities.All(p => p.Id != id))
            {
                publisherEntities.Add(publisherEntity);
            }
        }

        var publishers = publisherMapper.Map<ICollection<PublisherEntity>, ICollection<Publisher>>(publisherEntities);
        var publisherDtos = publisherMapper.Map<ICollection<Publisher>, ICollection<GetPublisherDto>>(publishers);

        return publisherDtos;
    }

    public void UpdatePublisher(UpdatePublisherDto publisherDto)
    {
        var publisher = publisherMapper.Map<UpdatePublisherDto, Publisher>(publisherDto);

        // validator.ValidatePublisherId(publisher.Id);
        var publisherEntity = publisherMapper.Map<Publisher, PublisherEntity>(publisher);

        if (databasesSyncDbService.ExistsInIdsSet(publisherEntity.Id) && publisherDbService.PublisherNotExists(publisher.Id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(publisherEntity.Id);
            var supplierDocument = supplierMongoService.GetSupplierByIdMongo(mongoId);
            var transferedPublisherEntity = publisherMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
            transferedPublisherEntity.Id = publisherEntity.Id;
            publisherDbService.CreatePublisherDb(transferedPublisherEntity);
        }

        publisherDbService.UpdatePublisherDb(publisherEntity);
    }

    public void DeletePublisher(Guid id)
    {
        validator.ValidatePublisherId(id);

        publisherDbService.DeletePublisherDb(id);
    }

    public ICollection<GetGameDto> GetGamesOfPublisher(string companyName)
    {
        /*validator.ValidateCompanyName(companyName);*/
        ICollection<GameEntity> gameEntities = [];
        if (publisherDbService.CompanyNameNotExists(companyName))
        {
            if (!supplierMongoService.CompanyNameNotExists(companyName))
            {
                var document = supplierMongoService.GetSupplierByCompanyName(companyName);
                var supplierId = databasesSyncDbService.TransferMongoIdToDb(document.Id);
                var productDocuments = supplierMongoService.GetProductsBySupplierId(document.SupplierID);
                foreach (var productDocument in productDocuments)
                {
                    PublisherEntity publisherEntity;
                    if (publisherDbService.PublisherNotExists(supplierId))
                    {
                        publisherEntity = publisherMapper.Map<SupplierDocument, PublisherEntity>(document);
                        publisherEntity.Id = supplierId;
                    }
                    else
                    {
                        publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(document.CompanyName);
                    }

                    var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                    var categoryId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                    GenreEntity genreEntity;
                    if (genreDbService.NotExists(categoryId))
                    {
                        genreEntity = publisherMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                        genreEntity.Id = categoryId;
                    }
                    else
                    {
                        genreEntity = genreDbService.GetGenreByGuid(categoryId);
                    }

                    var id = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                    var gameEntity = publisherMapper.Map<ProductDocument, GameEntity>(productDocument);
                    gameEntity.Id = id;
                    gameEntity.PublisherEntity = publisherEntity;
                    gameEntity.PublisherId = publisherEntity.Id;
                    gameEntity.GenreEntities = [genreEntity];
                    if (gameEntities.All(p => p.Id != id))
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
            gameEntities = publisherDbService.GetGamesOfPublisherDb(companyName);

            if (!supplierMongoService.CompanyNameNotExists(companyName))
            {
                var document = supplierMongoService.GetSupplierByCompanyName(companyName);
                var supplierId = databasesSyncDbService.TransferMongoIdToDb(document.Id);
                var productDocuments = supplierMongoService.GetProductsBySupplierId(document.SupplierID);
                foreach (var productDocument in productDocuments)
                {
                    PublisherEntity publisherEntity;
                    if (publisherDbService.PublisherNotExists(supplierId))
                    {
                        publisherEntity = publisherMapper.Map<SupplierDocument, PublisherEntity>(document);
                        publisherEntity.Id = supplierId;
                    }
                    else
                    {
                        publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(document.CompanyName);
                    }

                    var categoryDocument = productMongoService.GetCategoryOfProduct(productDocument.CategoryID);
                    var categoryId = databasesSyncDbService.TransferMongoIdToDb(categoryDocument.Id);
                    GenreEntity genreEntity;
                    if (genreDbService.NotExists(categoryId))
                    {
                        genreEntity = publisherMapper.Map<CategoryDocument, GenreEntity>(categoryDocument);
                        genreEntity.Id = categoryId;
                    }
                    else
                    {
                        genreEntity = genreDbService.GetGenreByGuid(categoryId);
                    }

                    var id = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                    var gameEntity = publisherMapper.Map<ProductDocument, GameEntity>(productDocument);
                    gameEntity.Id = id;
                    gameEntity.PublisherEntity = publisherEntity;
                    gameEntity.PublisherId = publisherEntity.Id;
                    gameEntity.GenreEntities = [genreEntity];
                    if (gameEntities.All(p => p.Id != id))
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

        var games = publisherMapper.Map<ICollection<GameEntity>, ICollection<Game>>(gameEntities);
        var gameDtos = publisherMapper.Map<ICollection<Game>, ICollection<GetGameDto>>(games);

        return gameDtos;
    }
}