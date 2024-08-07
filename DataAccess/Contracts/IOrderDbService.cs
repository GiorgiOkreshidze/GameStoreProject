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

    public void DeleteOrderDb(Guid id);
}