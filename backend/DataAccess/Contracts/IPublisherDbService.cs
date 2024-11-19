using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IPublisherDbService
{
    public void CreatePublisherDb(PublisherEntity publisherEntity);

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName);

    public PublisherEntity GetPublisherByGuid(Guid id);

    public ICollection<PublisherEntity> GetAllPublishersDb();

    public void UpdatePublisherDb(PublisherEntity publisherEntity);

    public void DeletePublisherDb(Guid id);

    public bool PublisherNotExists(Guid? id);

    public bool CompanyNameNotExists(string companyName);

    public PublisherEntity GetPublisherOfGameDb(string key);
}