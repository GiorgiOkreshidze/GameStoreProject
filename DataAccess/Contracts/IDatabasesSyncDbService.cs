namespace DataAccess.Contracts;

public interface IDatabasesSyncDbService
{
    public Guid TransferMongoIdToDb(string id);

    public bool ExistsInIdsSet(Guid id);

    public string GetMongoId(Guid id);
}