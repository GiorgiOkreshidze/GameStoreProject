using DataAccess.Contracts;
using DataAccess.Entities;
using MongoDbAccess.Contracts;

namespace DataAccess.LoggingDecorators;

public class OrderDbServiceLoggingDecorator(IOrderDbService orderDbService, IChangeLogMongoService logMongoService) : IOrderDbService
{
    private const string EntityName = "Order";

    public ICollection<OrderEntity> GetAllOrdersDb()
    {
        return orderDbService.GetAllOrdersDb();
    }

    public OrderEntity GetOrderByIdDb(Guid id)
    {
        return orderDbService.GetOrderByIdDb(id);
    }

    public ICollection<OrderGame> GetAllOrdersDetailsDb(Guid id)
    {
        return orderDbService.GetAllOrdersDetailsDb(id);
    }

    public void DeleteGameFromCartDb(string key)
    {
        var oldCart = orderDbService.GetCartDb();
        orderDbService.DeleteGameFromCartDb(key);
        var newCart = orderDbService.GetCartDb();
        logMongoService.LogChange("Cart", "Remove Game From Cart", oldCart, newCart);
    }

    public ICollection<OrderGame> GetCartDb()
    {
        return orderDbService.GetCartDb();
    }

    public ICollection<PaymentMethod> GetPaymentMethodsDb()
    {
        return orderDbService.GetPaymentMethodsDb();
    }

    public OrderEntity GetOrderEntity()
    {
        return orderDbService.GetOrderEntity();
    }

    public void OrderStatusChangeDb(bool nextStatus, Guid id)
    {
        orderDbService.OrderStatusChangeDb(nextStatus, id);
    }

    public void ChangeGameUnitInStock(OrderEntity orderEntity, ICollection<OrderGame> orderGames)
    {
        orderDbService.ChangeGameUnitInStock(orderEntity, orderGames);
    }

    public ICollection<OrderEntity> OrdersByIntervalDb(DateTime start, DateTime end)
    {
        return orderDbService.OrdersByIntervalDb(start, end);
    }

    public void DeleteOrderDb(Guid id)
    {
        var order = orderDbService.GetOrderEntity();
        orderDbService.DeleteOrderDb(id);
        logMongoService.LogChange(EntityName, "Delete Order", order, null);
    }

    public bool NotExists(Guid id)
    {
        return orderDbService.NotExists(id);
    }

    public int QuantityOfGame(Guid productId, Guid orderId)
    {
        return orderDbService.QuantityOfGame(productId, orderId);
    }

    public void UpdateOrderDetailQuantityDb(Guid id, int count)
    {
        orderDbService.UpdateOrderDetailQuantityDb(id, count);
    }

    public bool DeleteOrderDetailsDb(Guid id)
    {
        var oldOrder = orderDbService.GetOrderEntity();
        var result = orderDbService.DeleteOrderDetailsDb(id);
        var newOrder = orderDbService.GetOrderEntity();
        logMongoService.LogChange(EntityName, "Delete Order Details", oldOrder, newOrder);
        return result;
    }

    public bool ShipOrderDb(Guid id)
    {
        return orderDbService.ShipOrderDb(id);
    }

    public bool AddGameToOrderByKeyDb(Guid id, string key)
    {
        return orderDbService.AddGameToOrderByKeyDb(id, key);
    }
}