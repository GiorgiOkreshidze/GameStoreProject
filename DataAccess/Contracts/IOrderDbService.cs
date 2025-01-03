using DataAccess.Entities;

namespace DataAccess.Contracts;

public interface IOrderDbService
{
    public ICollection<OrderEntity> GetAllOrdersDb();

    public OrderEntity GetOrderByIdDb(Guid id);

    public ICollection<OrderGame> GetAllOrdersDetailsDb(Guid id);

    public void DeleteGameFromCartDb(string key);

    public ICollection<OrderGame> GetCartDb();

    public ICollection<PaymentMethod> GetPaymentMethodsDb();

    public OrderEntity GetOrderEntity();

    public void OrderStatusChangeDb(bool nextStatus, Guid id);

    public void ChangeGameUnitInStock(OrderEntity orderEntity, ICollection<OrderGame> orderGames);

    public ICollection<OrderEntity> OrdersByIntervalDb(DateTime start, DateTime end);

    public void DeleteOrderDb(Guid id);

    public bool NotExists(Guid id);

    public int QuantityOfGame(Guid productId, Guid orderId);

    public void UpdateOrderDetailQuantityDb(Guid id, int count);

    public bool DeleteOrderDetailsDb(Guid id);

    public bool ShipOrderDb(Guid id);

    public bool AddGameToOrderByKeyDb(Guid id, string key);
}