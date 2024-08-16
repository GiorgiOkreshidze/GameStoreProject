using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Services;

public class DatabasesSyncDbService(GameDbContext gameDbContext) : IDatabasesSyncDbService
{
    public Guid TransferMongoIdToDb(string id)
    {
        if (!gameDbContext.DatabaseIdsSet.Any(i => i.MongoId == id))
        {
            var ids = new DatabaseIds()
            {
                Id = Guid.NewGuid(),
                MongoId = id,
            };
            gameDbContext.DatabaseIdsSet.Add(ids);
            gameDbContext.SaveChanges();

            return ids.Id;
        }

        return gameDbContext.DatabaseIdsSet.FirstOrDefault(i => i.MongoId == id).Id;
    }

    public bool ExistsInIdsSet(Guid id)
    {
        return gameDbContext.DatabaseIdsSet.Any(i => i.Id == id);
    }

    public string GetMongoId(Guid id)
    {
        return gameDbContext.DatabaseIdsSet.FirstOrDefault(i => i.Id == id).MongoId;
    }
}