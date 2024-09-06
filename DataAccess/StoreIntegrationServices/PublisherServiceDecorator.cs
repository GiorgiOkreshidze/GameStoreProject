using AutoMapper;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.StoreIntegrationContracts;
using DataAccess.ValueObjects;
using Microsoft.IdentityModel.Tokens;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace DataAccess.StoreIntegrationServices;

public class PublisherServiceDecorator(IPublisherDbService publisherDbService,
    ISupplierMongoService supplierMongoService,
    IDatabasesSyncDbService databasesSyncDbService,
    IMapper mapper) : IPublisherDbService, IPublisherServiceDecorator
{
    public void CreatePublisherDb(PublisherEntity publisherEntity)
    {
        publisherDbService.CreatePublisherDb(publisherEntity);
    }

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName)
    {
        PublisherEntity publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(companyName);

        if (publisherEntity == null && !supplierMongoService.CompanyNameNotExists(companyName))
        {
            publisherEntity = MapSupplierDocument(supplierMongoService.GetSupplierByCompanyName(companyName));
            if (!databasesSyncDbService.CanSyncObject(publisherEntity.Id))
            {
                publisherEntity = null;
            }
        }

        return publisherEntity;
    }

    public PublisherEntity GetPublisherByGuid(Guid id)
    {
        PublisherEntity publisherEntity = publisherDbService.GetPublisherByGuid(id);

        if (publisherEntity == null && databasesSyncDbService.CanSyncObject(id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(id);
            if (!mongoId.IsNullOrEmpty())
            {
                publisherEntity = MapSupplierDocument(supplierMongoService.GetSupplierById(mongoId));
            }
        }

        return publisherEntity;
    }

    public ICollection<PublisherEntity> GetAllPublishersDb()
    {
        var publishers = publisherDbService.GetAllPublishersDb();

        var mongoIdBulk = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Publisher);

        var suppliers = supplierMongoService.GetSuppliersFiltered(mongoIdBulk);

        foreach (var supplier in suppliers)
        {
            publishers.Add(MapSupplierDocument(supplier));
        }

        return publishers;
    }

    public void UpdatePublisherDb(PublisherEntity publisherEntity)
    {
        TransferPublisherToDatabase(publisherEntity.Id);

        publisherDbService.UpdatePublisherDb(publisherEntity);
    }

    public void DeletePublisherDb(Guid id)
    {
        if (databasesSyncDbService.CanSyncObject(id))
        {
            databasesSyncDbService.MarkObjectAsSynced(id);
        }
        else
        {
            publisherDbService.DeletePublisherDb(id);
        }
    }

    public bool PublisherNotExists(Guid? id)
    {
        var publisher = GetPublisherByGuid((Guid)id!);

        return publisher == null;
    }

    public bool CompanyNameNotExists(string companyName)
    {
        var publisher = GetPublisherByCompanyNameDb(companyName);

        return publisher == null;
    }

    public PublisherEntity GetPublisherOfGameDb(string key)
    {
        var publisher = publisherDbService.GetPublisherOfGameDb(key);
        if (publisher is null)
        {
            var supplierDocument = supplierMongoService.GetPublisherByGameKey(key);
            publisher = MapSupplierDocument(supplierDocument);
            if (!databasesSyncDbService.CanSyncObject(publisher.Id))
            {
                publisher = null;
            }
        }

        return publisher;
    }

    public PublisherEntity GetPublisherBySupplierId(int supplierId)
    {
        var publisherDocument = supplierMongoService.GetSupplierBySupplierId(supplierId);
        var id = databasesSyncDbService.TransferMongoIdToDb(publisherDocument.Id);
        return GetPublisherByGuid(id);
    }

    public void TransferPublisherToDatabase(Guid publisherId)
    {
        if (databasesSyncDbService.CanSyncObject(publisherId))
        {
            var mongoId = databasesSyncDbService.GetMongoId(publisherId);

            var transferedPublisherEntity = MapSupplierDocument(supplierMongoService.GetSupplierByIdMongo(mongoId));
            publisherDbService.CreatePublisherDb(transferedPublisherEntity);
        }
    }

    public void TransferPublisherToDatabase(PublisherEntity publisherEntity)
    {
        if (databasesSyncDbService.CanSyncObject(publisherEntity.Id))
        {
            publisherDbService.CreatePublisherDb(publisherEntity);
        }
    }

    private PublisherEntity MapSupplierDocument(SupplierDocument document)
    {
        PublisherEntity publisherEntity;
        var id = databasesSyncDbService.TransferMongoIdToDb(document.Id);
        publisherEntity = mapper.Map<SupplierDocument, PublisherEntity>(document);
        publisherEntity.Id = id;

        return publisherEntity;
    }
}