namespace DataAccess.Contracts;

public interface IDatabasesSyncDbService
{
    public Guid TransferMongoIdToDb(string id);

    public bool ExistsInIdsSet(Guid id);

    public string GetMongoId(Guid id);

    public ICollection<string> GetExcludeMongoIds(string objectType);

    public bool CanSyncObject(Guid id);

    public void MarkObjectAsSynced(Guid id);

    public void IncreaseObjectViews(Guid id);

    public int GetObjectViews(Guid id);

    public void MarkAsDeleted(Guid id);

    public void PopulateIdSet();
}