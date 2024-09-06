using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.GameDtos;
using DTOs.PublisherDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class PublisherService(IPublisherDbService publisherDbService,
    IMapper publisherMapper) : IPublisherService
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
        PublisherEntity publisherEntity = publisherDbService.GetPublisherByCompanyNameDb(companyName);

        var publisher = publisherMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = publisherMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }

    public ICollection<GetPublisherDto> GetAllPublishers()
    {
        var publisherEntities = publisherDbService.GetAllPublishersDb();

        var publishers = publisherMapper.Map<ICollection<PublisherEntity>, ICollection<Publisher>>(publisherEntities);
        var publisherDtos = publisherMapper.Map<ICollection<Publisher>, ICollection<GetPublisherDto>>(publishers);

        return publisherDtos;
    }

    public void UpdatePublisher(UpdatePublisherDto publisherDto)
    {
        var publisher = publisherMapper.Map<UpdatePublisherDto, Publisher>(publisherDto);

        // validator.ValidatePublisherId(publisher.Id);
        var publisherEntity = publisherMapper.Map<Publisher, PublisherEntity>(publisher);

        publisherDbService.UpdatePublisherDb(publisherEntity);
    }

    public void DeletePublisher(Guid id)
    {
        publisherDbService.DeletePublisherDb(id);
    }

    public GetPublisherDto GetPublisherOfGame(string key)
    {
        /*validator.ValidateGameKey(key);*/
        PublisherEntity publisherEntity = publisherDbService.GetPublisherOfGameDb(key);
        /*if (gameDbService.KeyNotExists(key))
        {
            if (productMongoService.KeyNotExists(key))
            {
                throw new Exception("$this {key} gameKey not exists");
            }
            else
            {
                var productDocument = productMongoService.GetProductByGameKey(key);
                _ = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var supplierDocument = productMongoService.GetSupplierOfProduct(productDocument.SupplierID);
                var supplierdbId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                publisherEntity = gameMapper.Map<SupplierDocument, PublisherEntity>(supplierDocument);
                publisherEntity.Id = supplierdbId;
            }
        }
        else
        {
            publisherEntity = gameDbService.GetPublisherOfGameDb(key);
        }*/

        var publisher = publisherMapper.Map<PublisherEntity, Publisher>(publisherEntity);
        var publisherDto = publisherMapper.Map<Publisher, GetPublisherDto>(publisher);

        return publisherDto;
    }
}