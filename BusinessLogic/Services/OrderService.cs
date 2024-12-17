using System.Text;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
#pragma warning disable IDE0005
using DataAccess.Contracts;
using DataAccess.Entities;
#pragma warning restore IDE0005
using DTOs.OrderDtos;
using DTOs.PaymentDtos;
using DTOs.PaymentMethodDtos;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Extensions.Configuration;
#pragma warning disable IDE0005
using MongoDbAccess.Models;
#pragma warning restore IDE0005
#pragma warning disable IDE0005
using MongoDbAccess.Contracts;
#pragma warning restore IDE0005
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BusinessLogic.Services;

public class OrderService(IOrderDbService orderDbService,
    IMapper orderMapper,
    IConfiguration configuration,
    IDatabasesSyncDbService databasesSyncDbService,
    HttpClient httpClient,
    IOrderMongoService orderMongoService,
    GameValidator gameValidator,
    INotificationsService notificationsService) : IOrderService
{
    public ICollection<GetOrderDto> GetAllOrders(IntervalDto intervalDto)
    {
        DateTime startDate = intervalDto.Start ?? DateTime.MinValue;
        DateTime endDate = intervalDto.End ?? DateTime.MaxValue;

        var orderEntities = orderDbService.OrdersByIntervalDb(startDate, endDate);

        var orders = orderMapper.Map<ICollection<OrderEntity>, ICollection<Order>>(orderEntities);
        var orderDtos = orderMapper.Map<ICollection<Order>, ICollection<GetOrderDto>>(orders);

        return orderDtos;
    }

    public ICollection<GetOrderDto> GetOrders()
    {
        var orderEntities = orderDbService.GetAllOrdersDb();

        var orders = orderMapper.Map<ICollection<OrderEntity>, ICollection<Order>>(orderEntities);
        var orderDtos = orderMapper.Map<ICollection<Order>, ICollection<GetOrderDto>>(orders);

        return orderDtos;
    }

    public GetOrderDto GetOrderById(Guid id)
    {
        OrderEntity orderEntity = orderDbService.GetOrderByIdDb(id);

        var order = orderMapper.Map<OrderEntity, Order>(orderEntity);
        var orderDto = orderMapper.Map<Order, GetOrderDto>(order);

        return orderDto;
    }

    public ICollection<GetOrderDetailsDto> GetAllOrdersDetails(Guid id)
    {
        ICollection<OrderGame> orderGames = orderDbService.GetAllOrdersDetailsDb(id);

        var orderGameModels = orderMapper.Map<ICollection<OrderGame>, ICollection<OrderGameModel>>(orderGames);
        var orderDetailsDtos =
            orderMapper.Map<ICollection<OrderGameModel>, ICollection<GetOrderDetailsDto>>(orderGameModels);

        return orderDetailsDtos;
    }

    public void DeleteGameFromCart(string key)
    {
        orderDbService.DeleteGameFromCartDb(key);
    }

    public ICollection<GetOrderDetailsDto> GetCart()
    {
        var cart = orderDbService.GetCartDb();
        var cartModels = orderMapper.Map<ICollection<OrderGame>, ICollection<OrderGameModel>>(cart);
        var cartDtos =
            orderMapper.Map<ICollection<OrderGameModel>, ICollection<GetOrderDetailsDto>>(cartModels);

        return cartDtos;
    }

    public GetPaymentMethodDto GetPaymentMethods()
    {
        var paymentMethodsDb = orderDbService.GetPaymentMethodsDb();
        var paymentMethods = orderMapper.Map<ICollection<PaymentMethod>, ICollection<PaymentMethodModel>>(paymentMethodsDb);
        var paymentMethodsDtos = orderMapper.Map<ICollection<PaymentMethodModel>, ICollection<PaymentMethods>>(paymentMethods);
        GetPaymentMethodDto paymentMethodDtos = new()
        {
            PaymentMethods = paymentMethodsDtos,
        };

        return paymentMethodDtos;
    }

    public (byte[] FileBytes, string FileName) PaymentByBank(PaymentDto paymentDto)
    {
        var orderEntity = orderDbService.GetOrderEntity();
        var orderGames = orderDbService.GetAllOrdersDetailsDb(orderEntity.Id);
        foreach (var orderGame in orderGames)
        {
            gameValidator.CanBuyGame(orderGame.ProductId, orderGames.Count);
        }

        var sumOfPrices = CountSumOfPrices(orderGames);
        OrderStatusChange(true, orderEntity.Id);
        var invoice = GenerateInvoice(orderEntity, sumOfPrices);
        var fileName = $"Invoice_{Guid.Empty}.pdf";
        var filePath = Path.Combine(Path.GetTempPath(), fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            invoice
                .CopyTo(stream);
        }

        var fileBytes = File.ReadAllBytes(filePath);
        OrderStatusChange(true, orderEntity.Id);
        orderDbService.ChangeGameUnitInStock(orderEntity, orderGames);

        return (fileBytes, fileName);
    }

    public IBoxTerminalResponseDto PaymentByIBoxTermianl()
    {
        var baseUrl = configuration["Microservice:BaseUrl"];
        httpClient.BaseAddress = baseUrl != null ? new Uri(baseUrl) : throw new ArgumentNullException("baseUrl of Microservice is Null");
        var orderEntity = orderDbService.GetOrderEntity();
        OrderStatusChange(true, orderEntity.Id);
        var orderGames = orderDbService.GetAllOrdersDetailsDb(orderEntity.Id);
        foreach (var orderGame in orderGames)
        {
            gameValidator.CanBuyGame(orderGame.ProductId, orderGames.Count);
        }

        var transactionAmount = CountSumOfPrices(orderGames);

        var iBoxRequest = new IBoxTerminalRequestDto
        {
            AccountNumber = orderEntity.CustomerId,
            InvoiceNumber = orderEntity.Id,
            TransactionAmount = transactionAmount,
        };

        var jsonData = JsonConvert.SerializeObject(iBoxRequest);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = httpClient.PostAsync(httpClient.BaseAddress + "api/payments/ibox", content).Result;

        IBoxTerminalResponseDto iboxResponse;
        if (response.IsSuccessStatusCode)
        {
            string data = response.Content.ReadAsStringAsync().Result;
            var jsonResult = JObject.Parse(data);
            iboxResponse = new IBoxTerminalResponseDto
            {
                OrderId = Guid.Parse(jsonResult["invoiceNumber"].ToString()),
                PaymentDate = DateTime.UtcNow,
                Sum = (int)(jsonResult["amount"] ?? throw new InvalidOperationException("amount is incorrect")),
                UserId = Guid.Parse(jsonResult["accountNumber"].ToString()),
            };
            orderDbService.ChangeGameUnitInStock(orderEntity, orderGames);
            foreach (var orderGame in orderGames)
            {
                var gameId = orderGame.ProductId;
                var orderId = orderGame.OrderId;
                if (databasesSyncDbService.ExistsInIdsSet(gameId))
                {
                    var quantity = orderDbService.QuantityOfGame(gameId, orderId);
                    var mongoId = databasesSyncDbService.GetMongoId(orderId);
                    orderMongoService.ChangeProductUnitsInStock(mongoId, quantity);
                }
            }

            OrderStatusChange(true, orderEntity.Id);
        }
        else
        {
            OrderStatusChange(false, orderEntity.Id);
            throw new ApplicationException(response.Content.ReadAsStringAsync().Result);
        }

        return iboxResponse;
    }

    public void PaymentByVisa(PaymentDto paymentDto)
    {
        var baseUrl = configuration["Microservice:BaseUrl"];
        httpClient.BaseAddress = baseUrl != null ? new Uri(baseUrl) : throw new ArgumentNullException("baseUrl of Microservice is Null");
        var orderEntity = orderDbService.GetOrderEntity();
        OrderStatusChange(true, orderEntity.Id);
        var orderGames = orderDbService.GetAllOrdersDetailsDb(orderEntity.Id);
        foreach (var orderGame in orderGames)
        {
            gameValidator.CanBuyGame(orderGame.ProductId, orderGames.Count);
        }

        var transactionAmount = CountSumOfPrices(orderGames);
        var model = paymentDto.Model;

        var visaRequest = new VisaRequestDto
        {
            CardHolderName = model.Holder,
            CardNumber = model.CardNumber,
            Cvv = model.Cvv2,
            ExpirationMonth = model.MonthExpire,
            ExpirationYear = model.YearExpire,
            TransactionAmount = transactionAmount,
        };

        var jsonData = JsonConvert.SerializeObject(visaRequest);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = httpClient.PostAsync(httpClient.BaseAddress + "api/payments/visa", content).Result;

        if (response.IsSuccessStatusCode)
        {
            OrderStatusChange(true, orderEntity.Id);
            orderDbService.ChangeGameUnitInStock(orderEntity, orderGames);
            foreach (var orderGame in orderGames)
            {
                var gameId = orderGame.ProductId;
                var orderId = orderGame.OrderId;
                if (databasesSyncDbService.ExistsInIdsSet(gameId))
                {
                    var quantity = orderDbService.QuantityOfGame(gameId, orderId);
                    var mongoId = databasesSyncDbService.GetMongoId(gameId);
                    orderMongoService.ChangeProductUnitsInStock(mongoId, quantity);
                }
            }
        }
        else
        {
            OrderStatusChange(false, orderEntity.Id);
            throw new ApplicationException(response.Content.ReadAsStringAsync().Result);
        }
    }
    
    private void OrderStatusChange(bool nextStatus, Guid id)
    {
        orderDbService.OrderStatusChangeDb(nextStatus, id);
        var orderEntity = orderDbService.GetOrderByIdDb(id);
        var order = orderMapper.Map<OrderEntity, Order>(orderEntity);
        notificationsService.NotifyOrderStatusChangeAsync(order, order.Status.ToString());
    }

    public void UpdateOrderDetailQuantity(Guid id, CountDto countDto)
    {
        orderDbService.UpdateOrderDetailQuantityDb(id, countDto.Count);
    }

    public bool DeleteOrderDetails(Guid id)
    {
        return orderDbService.DeleteOrderDetailsDb(id);
    }

    public bool ShipOrder(Guid id)
    {
        return orderDbService.ShipOrderDb(id);
    }

    public bool AddGameToOrderByKey(Guid id, string key)
    {
        return orderDbService.AddGameToOrderByKeyDb(id, key);
    }

    private MemoryStream GenerateInvoice(OrderEntity orderEntity, int sumOfPrices)
    {
        var stream = new MemoryStream();
        var writer = new PdfWriter(stream);
        var pdf = new PdfDocument(writer);
        var document = new Document(pdf);

        // Add content to the PDF
        document.Add(new Paragraph($"User ID: {orderEntity.CustomerId}"));
        document.Add(new Paragraph($"Order ID: {orderEntity.Id}"));
        document.Add(new Paragraph($"Creation Date: {orderEntity.Date}"));
        document.Add(new Paragraph($"Date of Validity: {orderEntity.Date.AddDays(GetInvoiceValidityDays())}"));
        document.Add(new Paragraph($"Sum: {sumOfPrices}"));

        document.Close();
        var byteArray = stream.ToArray();
        var resultStream = new MemoryStream(byteArray);
        return resultStream;
    }

    private int GetInvoiceValidityDays()
    {
        var validityDays = configuration.GetSection("BankPaymentDateOfValidity")["InvoiceIsValid"]
                           ?? throw new ArgumentNullException("Validity days is Null");
        return int.Parse(validityDays);
    }

    private static int CountSumOfPrices(ICollection<OrderGame> orderGames)
    {
        var sum = 0;
        foreach (var orderGame in orderGames)
        {
            sum += (int)orderGame.Price;
        }

        return sum;
    }
}