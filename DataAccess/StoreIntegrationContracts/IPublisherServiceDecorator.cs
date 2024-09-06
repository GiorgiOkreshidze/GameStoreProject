using DataAccess.Entities;

namespace DataAccess.StoreIntegrationContracts;

public interface IPublisherServiceDecorator
{
    public PublisherEntity GetPublisherBySupplierId(int supplierId);

    public void TransferPublisherToDatabase(Guid publisherId);

    public void TransferPublisherToDatabase(PublisherEntity publisherEntity);
}