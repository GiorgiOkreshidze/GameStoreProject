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
        return gameDbContext.OrderEntities.FirstOrDefault(o => o.Id == id);
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

    public int QuantityOfGame(Guid productId, Guid orderId)
    {
        return gameDbContext.OrderGames.FirstOrDefault(o => o.ProductId == productId &&
                                                            o.OrderId == orderId).Quantity;
    }

    public void UpdateOrderDetailQuantityDb(Guid id, int count)
    {
        var orderDetails = gameDbContext.OrderGames.FirstOrDefault(o => o.OrderId == id);

        orderDetails.Quantity = count;
        gameDbContext.SaveChanges();
    }

    public bool DeleteOrderDetailsDb(Guid id)
    {
        var result = gameDbContext.OrderGames.FirstOrDefault(orderGame => orderGame.OrderGameId == id);

        if (result is null)
        {
            return false;
        }

        gameDbContext.OrderGames.Remove(result);
        gameDbContext.SaveChanges();
        return true;
    }

    public bool ShipOrderDb(Guid id)
    {
        var result = gameDbContext.OrderEntities.FirstOrDefault(order => order.Id == id);

        if (result is null)
        {
            return false;
        }

        result.ShippedDate = DateTime.Now;
        gameDbContext.SaveChanges();
        return true;
    }

    public bool AddGameToOrderByKeyDb(Guid id, string key)
    {
        var order = gameDbContext.OrderEntities.Include(orderEntity => orderEntity.GameEntities).FirstOrDefault(order => order.Id == id);
        if (order is null)
        {
            return false;
        }

        var game = gameDbContext.GameEntities.FirstOrDefault(game => game.Key == key);
        if (game is null)
        {
            return false;
        }

        if (order.GameEntities.Contains(game))
        {
            var orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.OrderId == order.Id) ??
                        throw new ArgumentNullException();
            orderGame.Quantity += 1;
        }
        else
        {
            order.GameEntities.Add(game);
            gameDbContext.SaveChanges();
            var orderGame = gameDbContext.OrderGames.FirstOrDefault(o => o.ProductId == game.Id) ?? throw new ArgumentNullException();
            orderGame.Price = game.Price;
            orderGame.Discount = game.Discount;
            orderGame.Quantity = 1;
        }

        gameDbContext.SaveChanges();
        return true;
    }

    public ICollection<Guid> GetOrdersGamesId(OrderEntity orderEntity)
    {
        ICollection<Guid> collection = [];
        var order = gameDbContext.OrderEntities.Include(o => o.GameEntities)
            .FirstOrDefault(o => o.Id == orderEntity.Id);
        foreach (var gameEntity in order.GameEntities)
        {
            collection.Add(gameEntity.Id);
        }

        return collection;
    }

    public ICollection<OrderEntity> OrdersByIntervalDb(DateTime start, DateTime end)
    {
        return gameDbContext.OrderEntities.Where(o => o.Date >= start && o.Date <= end).ToList();
    }

    public void DeleteOrderDb(Guid id)
    {
        var order = gameDbContext.OrderEntities.FirstOrDefault(o => o.Id == id) ?? throw new ArgumentNullException();
        gameDbContext.OrderEntities.Remove(order);
        gameDbContext.SaveChanges();
    }

    public bool NotExists(Guid id)
    {
        return !gameDbContext.OrderEntities.AsNoTracking().Any(t => t.Id == id);
    }
}