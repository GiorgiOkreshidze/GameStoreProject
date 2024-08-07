using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;
using DataAccess.Enums;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services;

#pragma warning disable IDE0305
public class OrderDbService(GameDbContext gameDbContext) : IOrderDbService
{
    private static readonly Guid VirtualCustomerGuid = new("3fa85f64-5717-4562-b3fc-2c963f66afa6");

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
                              .FirstOrDefault(o => (o.CustomerId == VirtualCustomerGuid && o.Status == OrderStatus.Checkout)
                                                   || (o.CustomerId == VirtualCustomerGuid && o.Status == OrderStatus.Open)) ??
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
        var orderEntity = gameDbContext.OrderEntities.FirstOrDefault(o => (o.CustomerId == VirtualCustomerGuid
                                                                          && o.Status == OrderStatus.Open)
                                                                          || (o.CustomerId == VirtualCustomerGuid
                                                                              && o.Status == OrderStatus.Checkout));

        return orderEntity is null ? [] : gameDbContext.OrderGames.Where(o => o.OrderId == orderEntity.Id).ToList();
    }

    public ICollection<PaymentMethod> GetPaymentMethodsDb()
    {
        return gameDbContext.PaymentMethods.AsNoTracking().ToList();
    }

    public OrderEntity GetOrderEntity()
    {
        return gameDbContext.OrderEntities.FirstOrDefault(o => (o.CustomerId == VirtualCustomerGuid
                                                                && o.Status == OrderStatus.Open)
                                                               || (o.CustomerId == VirtualCustomerGuid
                                                                   && o.Status == OrderStatus.Checkout)) ?? throw new ArgumentNullException();
    }

    public void OrderStatusChangeDb(bool nextStatus, Guid id)
    {
        var orderEntity = GetOrderByIdDb(id);
        if (nextStatus)
        {
            orderEntity.Status += 1;
        }
        else
        {
            orderEntity.Status = OrderStatus.Cancelled;
        }

        gameDbContext.SaveChanges();
    }

    public void ChangeGameUnitInStock(OrderEntity orderEntity, ICollection<OrderGame> orderGames)
    {
        var order = gameDbContext.OrderEntities.Include(o => o.GameEntities)
            .FirstOrDefault(o => o.Id == orderEntity.Id);
        foreach (var gameEntity in order.GameEntities)
        {
            var game = gameDbContext.GameEntities.FirstOrDefault(g => g.Id == gameEntity.Id);
            var orderGame = orderGames.FirstOrDefault(o => o.ProductId == gameEntity.Id);

            game.UnitInStock -= orderGame.Quantity;
            gameDbContext.SaveChanges();
        }
    }

    public void DeleteOrderDb(Guid id)
    {
        var order = gameDbContext.OrderEntities.FirstOrDefault(o => o.Id == id) ?? throw new ArgumentNullException();
        gameDbContext.OrderEntities.Remove(order);
        gameDbContext.SaveChanges();
    }
}