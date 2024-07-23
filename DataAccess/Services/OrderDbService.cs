using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

#pragma warning disable IDE0305
public class OrderDbService(GameDbContext gameDbContext) : IOrderDbService
{
    public ICollection<OrderEntity> GetAllOrdersDb()
    {
        return gameDbContext.OrderEntities.AsNoTracking().ToList();
    }

    public OrderEntity GetOrderByIdDb(Guid id)
    {
        return gameDbContext.OrderEntities.FirstOrDefault(o => o.Id == id) ?? throw new ArgumentNullException();
    }

    public ICollection<OrderGame> GetAllOrdersDetailsDb(Guid id)
    {
        return gameDbContext.OrderGames.Where(o => o.OrderId == id).ToList();
    }

    public void DeleteGameFromCartDb(string key)
    {
        var gameEntity = gameDbContext.GameEntities.FirstOrDefault(g => g.Key == key) ?? throw new ArgumentNullException();
        var orderEntity = gameDbContext.OrderEntities.Include(orderEntity => orderEntity.GameEntities)
                              .FirstOrDefault(o => o.CustomerId == Guid.Empty) ??
                          throw new ArgumentNullException();
        if (orderEntity.GameEntities.Count == 1)
        {
            orderEntity.GameEntities.Remove(gameEntity);
            gameDbContext.OrderEntities.Remove(orderEntity);
            gameDbContext.SaveChanges();
        }
        else
        {
            orderEntity.GameEntities.Remove(gameEntity);
            gameDbContext.SaveChanges();
        }
    }

    public ICollection<OrderGame> GetCartDb()
    {
        var orderEntity = gameDbContext.OrderEntities.FirstOrDefault(o => o.CustomerId == Guid.Empty) ?? throw new ArgumentNullException();

        return gameDbContext.OrderGames.Where(o => o.OrderId == orderEntity.Id).ToList();
    }

    public ICollection<PaymentMethod> GetPaymentMethodsDb()
    {
        return gameDbContext.PaymentMethods.AsNoTracking().ToList();
    }

    public OrderEntity GetOrderEntity()
    {
        return gameDbContext.OrderEntities.FirstOrDefault(o => o.CustomerId == Guid.Empty) ?? throw new ArgumentNullException();
    }
}