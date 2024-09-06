namespace DataAccess.StoreIntegrationContracts;

public interface IGameServiceDecorator
{
    public void TransferGameFromMongoToDb(string key);
}