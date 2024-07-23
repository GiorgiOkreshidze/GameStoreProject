using System.Text;
using AutoMapper;
using BusinessLogic.Contracts;
using BusinessLogic.Models;
using BusinessLogic.Validations;
using DataAccess.Contracts;
using DataAccess.Entities;
using DTOs.OrderDtos;
#pragma warning disable IDE0005
using DTOs.PaymentMethodDtos;
#pragma warning restore IDE0005
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
#pragma warning disable IDE0005
using DTOs.PaymentDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class OrderService(IOrderDbService orderDbService, IMapper orderMapper, IValidationsHandler validator,
    IConfiguration configuration, HttpClient httpClient) : IOrderService
{
    public ICollection<GetOrderDto> GetAllOrders()
    {
        var orderEntities = orderDbService.GetAllOrdersDb();
        var orders = orderMapper.Map<ICollection<OrderEntity>, ICollection<Order>>(orderEntities);
        var orderDtos = orderMapper.Map<ICollection<Order>, ICollection<GetOrderDto>>(orders);

        return orderDtos;
    }

    public GetOrderDto GetOrderById(Guid id)
    {
        var orderEntity = orderDbService.GetOrderByIdDb(id);
        var order = orderMapper.Map<OrderEntity, Order>(orderEntity);
        var orderDto = orderMapper.Map<Order, GetOrderDto>(order);

        return orderDto;
    }

    public ICollection<GetOrderDetailsDto> GetAllOrdersDetails(Guid id)
    {
        var orderGames = orderDbService.GetAllOrdersDetailsDb(id);
        var orderGameModels = orderMapper.Map<ICollection<OrderGame>, ICollection<OrderGameModel>>(orderGames);
        var orderDetailsDtos =
            orderMapper.Map<ICollection<OrderGameModel>, ICollection<GetOrderDetailsDto>>(orderGameModels);

        return orderDetailsDtos;
    }

    public void DeleteGameFromCart(string key)
    {
        validator.ValidateGameKey(key);
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

    public ICollection<GetPaymentMethodDto> GetPaymentMethods()
    {
        var paymentMethodsDb = orderDbService.GetPaymentMethodsDb();
        var paymentMethods = orderMapper.Map<ICollection<PaymentMethod>, ICollection<PaymentMethodModel>>(paymentMethodsDb);
        var paymentMethodDtos = orderMapper.Map<ICollection<PaymentMethodModel>, ICollection<GetPaymentMethodDto>>(paymentMethods);

        return paymentMethodDtos;
    }

    public (byte[] FileBytes, string FileName) PaymentByBank(PaymentDto paymentDto)
    {
        var orderEntity = orderDbService.GetOrderEntity();
        var invoice = GenerateInvoice(orderEntity);
        var fileName = $"Invoice_{Guid.Empty}.pdf";
        var filePath = Path.Combine(Path.GetTempPath(), fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            invoice
                .CopyTo(stream);
        }

        var fileBytes = File.ReadAllBytes(filePath);
        return (fileBytes, fileName);
    }

    public IBoxTerminalResponseDto PaymentByIBoxTermianl()
    {
        var baseUrl = configuration["Microservice:BaseUrl"];
        httpClient.BaseAddress = baseUrl != null ? new Uri(baseUrl) : throw new ArgumentNullException("baseUrl of Microservice is Null");
        var orderEntity = orderDbService.GetOrderEntity();
        var orderGames = orderDbService.GetAllOrdersDetailsDb(orderEntity.Id);

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
            iboxResponse = JsonConvert.DeserializeObject<IBoxTerminalResponseDto>(data);
        }
        else
        {
            throw new ApplicationException(response.Content.ReadAsStringAsync().Result);
        }

        return iboxResponse;
    }

    public void PaymentByVisa(PaymentDto paymentDto)
    {
        var baseUrl = configuration["Microservice:BaseUrl"];
        httpClient.BaseAddress = baseUrl != null ? new Uri(baseUrl) : throw new ArgumentNullException("baseUrl of Microservice is Null");
        var orderEntity = orderDbService.GetOrderEntity();
        var orderGames = orderDbService.GetAllOrdersDetailsDb(orderEntity.Id);

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
        }
        else
        {
            throw new ApplicationException(response.Content.ReadAsStringAsync().Result);
        }
    }

    private MemoryStream GenerateInvoice(OrderEntity orderEntity)
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
        document.Add(new Paragraph($"Sum: {orderEntity.Status}"));

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

        return sum + sum;
    }
}