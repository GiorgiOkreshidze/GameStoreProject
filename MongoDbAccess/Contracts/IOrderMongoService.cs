#pragma warning disable IDE0005
using MongoDbAccess.Models;
#pragma warning restore IDE0005

namespace MongoDbAccess.Contracts;

public interface IOrderMongoService
{
    public ICollection<OrderDocument> GetAllMongo();

    public ICollection<OrderDocument> OrdersByIntervalMongo(DateTime start, DateTime end);

    public OrderDocument GetOrderById(string id);

    public ICollection<OrderDetailsDocument> GetOrderDetailsByOrderId(int orderId);

    public ProductDocument GetProductByProductId(int productId);

    public void ChangeProductUnitsInStock(string mongoId, int quantity);
}