using System.Data.SqlTypes;
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
        var publisherEntity = gameDbContext.PublisherEntities.FirstOrDefault(x => x.CompanyName == companyName)?? throw new SqlNullValueException();

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
        var publisherEntity = gameDbContext.PublisherEntities.FirstOrDefault(t => t.Id == id)?? throw new SqlNullValueException();
        
        gameDbContext.Entry(publisherEntity).State = EntityState.Deleted;
        gameDbContext.SaveChanges();
    }

    public ICollection<GameEntity> GetGamesOfPublisherDb(string companyName)
    {
        return gameDbContext.GameEntities
            .Where(t => t.PublisherEntity.CompanyName == companyName)
            .ToList();
    }

    public bool PublisherNotExists(Guid? id)
    {
        return !gameDbContext.PublisherEntities.Any(t => t.Id == id);
    }
    
    public bool CompanyNameNotExists(string companyName)
    {
        return !gameDbContext.PublisherEntities.Any(t => t.CompanyName == companyName);
    }
}