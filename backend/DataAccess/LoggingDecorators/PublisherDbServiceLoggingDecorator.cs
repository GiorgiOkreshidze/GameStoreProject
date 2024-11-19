using DataAccess.Contracts;
using DataAccess.Entities;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class PublisherDbServiceLoggingDecorator(IPublisherDbService publisherDbService, IChangeLogMongoService logMongoService) : IPublisherDbService
{
    private const string EntityName = "Publisher";

    public void CreatePublisherDb(PublisherEntity publisherEntity)
    {
        publisherDbService.CreatePublisherDb(publisherEntity);
        logMongoService.LogChange(EntityName, "Add Publisher", null, publisherEntity);
    }

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName)
    {
        return publisherDbService.GetPublisherByCompanyNameDb(companyName);
    }

    public PublisherEntity GetPublisherByGuid(Guid id)
    {
        return publisherDbService.GetPublisherByGuid(id);
    }

    public ICollection<PublisherEntity> GetAllPublishersDb()
    {
        return publisherDbService.GetAllPublishersDb();
    }

    public void UpdatePublisherDb(PublisherEntity publisherEntity)
    {
        var oldPublisher = publisherDbService.GetPublisherByGuid(publisherEntity.Id);
        publisherDbService.UpdatePublisherDb(publisherEntity);
        logMongoService.LogChange(EntityName, "Update Publisher", oldPublisher, publisherEntity);
    }

    public void DeletePublisherDb(Guid id)
    {
        var oldPublisher = publisherDbService.GetPublisherByGuid(id);
        publisherDbService.DeletePublisherDb(id);
        logMongoService.LogChange(EntityName, "Delete Publisher", oldPublisher, null);
    }

    public bool PublisherNotExists(Guid? id)
    {
        return publisherDbService.PublisherNotExists(id);
    }

    public bool CompanyNameNotExists(string companyName)
    {
        return publisherDbService.CompanyNameNotExists(companyName);
    }

    public PublisherEntity GetPublisherOfGameDb(string key)
    {
        return publisherDbService.GetPublisherOfGameDb(key);
    }
}