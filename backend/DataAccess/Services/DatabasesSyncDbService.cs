using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.ValueObjects;
using Microsoft.EntityFrameworkCore;
using MongoDbAccess.Contracts;
using MongoDbAccess.MongoDTOs;

namespace DataAccess.Services;

public class DatabasesSyncDbService(GameDbContext gameDbContext,
    ICategoryMongoService categoryMongoService,
    IOrderMongoService orderMongoService,
    IProductMongoService productMongoService,
    ISupplierMongoService supplierMongoService) : IDatabasesSyncDbService
{
    public Guid TransferMongoIdToDb(string id)
    {
        if (!gameDbContext.DatabaseIdsSet.AsNoTracking().Any(i => i.MongoId == id))
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

    public ICollection<string> GetExcludeMongoIds(string objectType)
    {
        return [.. gameDbContext.DatabaseIdsSet.Where(a => a.ObjectType == objectType && a.Synchronized).Select(a => a.MongoId)];
    }

    public bool CanSyncObject(Guid id)
    {
        return gameDbContext.DatabaseIdsSet.Any(a => a.Id == id && !a.Synchronized);
    }

    public void MarkObjectAsSynced(Guid id)
    {
        var idObject = gameDbContext.DatabaseIdsSet.Where(a => a.Id == id).FirstOrDefault();
        idObject.Synchronized = true;
        gameDbContext.Update(idObject);
        gameDbContext.SaveChanges();

        var entry = gameDbContext.Entry(idObject);
        entry.State = EntityState.Detached;
    }

    public void IncreaseObjectViews(Guid id)
    {
        var count = gameDbContext.DatabaseIdsSet.Where(a => a.Id == id).FirstOrDefault();

        count.ViewCount = count.ViewCount == null ? 1 : count.ViewCount + 1;

        gameDbContext.Update(count);
        gameDbContext.SaveChanges();

        gameDbContext.Entry(count).State = EntityState.Detached;
    }

    public int GetObjectViews(Guid id)
    {
        int count = gameDbContext.DatabaseIdsSet.Where(a => a.Id == id).AsNoTracking().Select(a => a.ViewCount).FirstOrDefault() ?? 0;

        return count;
    }

    public void MarkAsDeleted(Guid id)
    {
        var entity = gameDbContext.DatabaseIdsSet.FirstOrDefault(e => e.Id == id);

        entity.Deleted = true;

        gameDbContext.SaveChanges();
    }

    public void PopulateIdSet()
    {
        if (!gameDbContext.DatabaseIdsSet.Any())
        {
            foreach (var document in categoryMongoService.GetAllMongo())
            {
                var genre = new DatabaseIds
                {
                    Id = Guid.NewGuid(),
                    Deleted = false,
                    MongoId = document.Id,
                    ObjectType = DatabaseObjectType.Genre,
                    Synchronized = false,
                };

                gameDbContext.Add(genre);
            }

            foreach (var document in productMongoService.GetAllMongo(new ProductMongoFilter()))
            {
                var game = new DatabaseIds
                {
                    Id = Guid.NewGuid(),
                    Deleted = false,
                    MongoId = document.Id,
                    ObjectType = DatabaseObjectType.Game,
                    Synchronized = false,
                };

                gameDbContext.Add(game);
            }

            foreach (var document in supplierMongoService.GetAllSuppliersMongo())
            {
                var publisher = new DatabaseIds
                {
                    Id = Guid.NewGuid(),
                    Deleted = false,
                    MongoId = document.Id,
                    ObjectType = DatabaseObjectType.Publisher,
                    Synchronized = false,
                };

                gameDbContext.Add(publisher);
            }

            foreach (var document in orderMongoService.GetAllMongo())
            {
                var order = new DatabaseIds
                {
                    Id = Guid.NewGuid(),
                    Deleted = false,
                    MongoId = document.Id,
                    ObjectType = DatabaseObjectType.Order,
                    Synchronized = false,
                };

                gameDbContext.Add(order);
            }

            gameDbContext.SaveChanges();
        }
    }
}