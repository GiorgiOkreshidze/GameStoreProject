using DTOs.OrderDtos;
#pragma warning disable IDE0005
using DTOs.PaymentDtos;
using DTOs.PaymentMethodDtos;
#pragma warning restore IDE0005

namespace BusinessLogic.Contracts;

public interface IOrderService
{
    public ICollection<GetOrderDto> GetAllOrders();

    public GetOrderDto GetOrderById(Guid id);

    public ICollection<GetOrderDetailsDto> GetAllOrdersDetails(Guid id);

    public void DeleteGameFromCart(string key);

    public ICollection<GetOrderDetailsDto> GetCart();

    public ICollection<GetPaymentMethodDto> GetPaymentMethods();

    public (byte[] FileBytes, string FileName) PaymentByBank(PaymentDto paymentDto);

    public IBoxTerminalResponseDto PaymentByIBoxTermianl();

    public void PaymentByVisa(PaymentDto paymentDto);
}