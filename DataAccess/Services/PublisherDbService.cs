using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

public class PublisherDbService(GameDbContext gameDbContext) : IPublisherDbService
{
    public void CreatePublisherDb(PublisherEntity publisherEntity)
    {
        gameDbContext.PublisherEntities.Add(publisherEntity);
        gameDbContext.SaveChanges();
    }

    public PublisherEntity GetPublisherByCompanyNameDb(string companyName)
    {
        var publisherEntity = gameDbContext.PublisherEntities.First(x => x.CompanyName == companyName);

        return publisherEntity;
    }

    public ICollection<PublisherEntity> GetAllPublishersDb()
    {
        return gameDbContext.PublisherEntities.AsNoTracking().ToList();
    }

    public void UpdatePublisherDb(PublisherEntity publisherEntity)
    {
        gameDbContext.Entry(publisherEntity).State = EntityState.Modified;
        gameDbContext.SaveChanges();
    }

    public void DeletePublisherDb(Guid id)
    {
        var publisherEntity = (from t in gameDbContext.PublisherEntities
            where t.Id == id
            select t).First();
        
        gameDbContext.Entry(publisherEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName)
    {
        return (from t in gameDbContext.GameEntities
            where t.PublisherEntity.CompanyName == companyName
            select t).ToList();
    }

    public bool PublisherNotExists(Guid? id)
    {
        return !gameDbContext.PublisherEntities.Any(t => t.Id == id);
    }
}