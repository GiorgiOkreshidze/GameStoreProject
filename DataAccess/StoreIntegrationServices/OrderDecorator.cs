using AutoMapper;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.ValueObjects;
using MongoDbAccess.Contracts;
using MongoDbAccess.Models;

namespace DataAccess.StoreIntegrationServices;

public class OrderDecorator(
    IOrderDbService orderDbService,
    IOrderMongoService orderMongoService,
    IDatabasesSyncDbService databasesSyncDbService,
    IMapper orderMapper) : IOrderDbService
{
    public ICollection<OrderEntity> GetAllOrdersDb()
    {
        throw new NotImplementedException();
    }

    public OrderEntity GetOrderByIdDb(Guid id)
    {
        var orderEntity = orderDbService.GetOrderByIdDb(id);

        if (orderEntity == null)
        {
            if (databasesSyncDbService.ExistsInIdsSet(id))
            {
                var mongoId = databasesSyncDbService.GetMongoId(id);
                var orderDocument = orderMongoService.GetOrderById(mongoId);
                orderEntity = orderMapper.Map<OrderDocument, OrderEntity>(orderDocument);
                orderEntity.Id = id;
            }
        }

        return orderEntity;
    }

    public ICollection<OrderGame> GetAllOrdersDetailsDb(Guid id)
    {
        var orderGames = orderDbService.GetAllOrdersDetailsDb(id);

        ICollection<string> mongoIdsOfOrderGames = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Order);

        if (databasesSyncDbService.ExistsInIdsSet(id))
        {
            var mongoId = databasesSyncDbService.GetMongoId(id);
            var orderDocument = orderMongoService.GetOrderById(mongoId);
            var orderDetailsDocuments = orderMongoService.GetOrderDetailsByOrderId(orderDocument.OrderID, mongoIdsOfOrderGames);
            foreach (var orderDetailsDocument in orderDetailsDocuments)
            {
                var productDocument = orderMongoService.GetProductByProductId(orderDetailsDocument.ProductID);
                var productId = databasesSyncDbService.TransferMongoIdToDb(productDocument.Id);
                var orderGame = orderMapper.Map<OrderDetailsDocument, OrderGame>(orderDetailsDocument);
                orderGame.OrderId = id;
                orderGame.ProductId = productId;
                orderGames.Add(orderGame);
            }
        }

        return orderGames;
    }

    public void DeleteGameFromCartDb(string key)
    {
        orderDbService.DeleteGameFromCartDb(key);
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
        foreach (var orderGame in orderGames)
        {
            var productId = orderGame.ProductId;
            var orderId = orderGame.OrderId;
            if (databasesSyncDbService.ExistsInIdsSet(productId))
            {
                var quantity = orderDbService.QuantityOfGame(productId, orderId);
                var mongoId = databasesSyncDbService.GetMongoId(productId);
                orderMongoService.ChangeProductUnitsInStock(mongoId, quantity);
            }
        }
    }

    public ICollection<OrderEntity> OrdersByIntervalDb(DateTime start, DateTime end)
    {
        var orderEntities = orderDbService.OrdersByIntervalDb(start, end);

        ICollection<string> mongoIdsOfOrders = databasesSyncDbService.GetExcludeMongoIds(DatabaseObjectType.Genre);

        var orderDocuments = orderMongoService.OrdersByIntervalMongo(start, end, mongoIdsOfOrders);

        foreach (var orderDocument in orderDocuments)
        {
            orderEntities.Add(MapOrderDocument(orderDocument));
        }

        return orderEntities;
    }

    public void DeleteOrderDb(Guid id)
    {
        orderDbService.DeleteOrderDb(id);
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
        return orderDbService.DeleteOrderDetailsDb(id);
    }

    public bool ShipOrderDb(Guid id)
    {
        return orderDbService.ShipOrderDb(id);
    }

    public bool AddGameToOrderByKeyDb(Guid id, string key)
    {
        return orderDbService.AddGameToOrderByKeyDb(id, key);
    }

    private OrderEntity MapOrderDocument(OrderDocument orderDocument)
    {
        var id = databasesSyncDbService.TransferMongoIdToDb(orderDocument.Id);
        var customerId = databasesSyncDbService.TransferMongoIdToDb(orderDocument.CustomerID);
        var orderEntity = orderMapper.Map<OrderDocument, OrderEntity>(orderDocument);
        orderEntity.Id = id;
        orderEntity.CustomerId = customerId;

        return orderEntity;
    }
}