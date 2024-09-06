using System.Data.SqlTypes;
using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;
#pragma warning disable IDE0305
public class PublisherDbService(GameDbContext gameDbContext) : IPublisherDbService
{
    public void CreatePublisherDb(PublisherEntity publisherEntity)
    {
        gameDbContext.PublisherEntities.Add(publisherEntity);
        gameDbContext.SaveChanges();

        var gameEntry = gameDbContext.Entry(publisherEntity);
        if (gameEntry.State != EntityState.Detached)
        {
            gameEntry.State = EntityState.Detached;
        }
    }

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName)
    {
        var publisherEntity = gameDbContext.PublisherEntities.AsNoTracking().FirstOrDefault(x => x.CompanyName == companyName);

        return publisherEntity;
    }

    public PublisherEntity GetPublisherByGuid(Guid id)
    {
        var publisherEntity = gameDbContext.PublisherEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);

        return publisherEntity;
    }

    public ICollection<PublisherEntity> GetAllPublishersDb()
    {
        return gameDbContext.PublisherEntities.AsNoTracking().ToList();
    }

    public void UpdatePublisherDb(PublisherEntity publisherEntity)
    {
        gameDbContext.PublisherEntities.Update(publisherEntity);
        gameDbContext.SaveChanges();
    }

    public void DeletePublisherDb(Guid id)
    {
        var publisherEntity = gameDbContext.PublisherEntities.FirstOrDefault(t => t.Id == id) ?? throw new SqlNullValueException();

        gameDbContext.Entry(publisherEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public bool PublisherNotExists(Guid? id)
    {
        return !gameDbContext.PublisherEntities.AsNoTracking().Any(t => t.Id == id);
    }

    public bool CompanyNameNotExists(string companyName)
    {
        return !gameDbContext.PublisherEntities.Any(t => t.CompanyName == companyName);
    }

    public PublisherEntity GetPublisherOfGameDb(string key)
    {
        return gameDbContext.PublisherEntities.Where(p => p.GameEntities.Any(g => g.Key == key)).FirstOrDefault();
    }
}