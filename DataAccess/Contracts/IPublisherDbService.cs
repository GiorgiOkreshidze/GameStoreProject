using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IPublisherDbService
{
    public void CreatePublisherDb(PublisherEntity publisherEntity);

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName);

    public ICollection<PublisherEntity> GetAllPublishersDb();

    public void UpdatePublisherDb(PublisherEntity publisherEntity);

    public void DeletePublisherDb(Guid id);

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName);
    
    public bool PublisherNotExists(Guid? id);

    public bool CompanyNameNotExists(string companyName);
}