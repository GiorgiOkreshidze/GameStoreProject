using BusinessLogic.Contracts;
#pragma warning disable IDE0005
using DTOs.PaymentDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController(IOrderService orderService) : Controller
{
    [HttpGet]
    public IActionResult GetAllOrders()
    {
        return Ok(orderService.GetAllOrders());
    }

    [HttpGet("{id}")]
    public IActionResult GetOrderById(Guid id)
    {
        return Ok(orderService.GetOrderById(id));
    }

    [HttpGet("{id}/details")]
    public IActionResult GetAllOrdersDetails(Guid id)
    {
        return Ok(orderService.GetAllOrdersDetails(id));
    }

    [HttpDelete("cart/{key}")]
    public IActionResult DeleteGameFromCart(string key)
    {
        orderService.DeleteGameFromCart(key);
        return Ok();
    }

    [HttpGet("cart")]
    public IActionResult GetCart()
    {
        return Ok(orderService.GetCart());
    }

    [HttpGet("payment-methods")]
    public IActionResult GetPaymentMethods()
    {
        return Ok(orderService.GetPaymentMethods());
    }

    [HttpPost("payment")]
    public IActionResult Payment(PaymentDto paymentDto)
    {
        if (paymentDto.Method == "Bank")
        {
            var (fileBytes, fileName) = orderService.PaymentByBank(paymentDto);
            return File(fileBytes, "application/pdf", fileName);
        }

        if (paymentDto.Method == "IBox terminal")
        {
            Ok(orderService.PaymentByIBoxTermianl());
        }

        if (paymentDto.Method == "Visa")
        {
            orderService.PaymentByVisa(paymentDto);
        }

        return BadRequest("Unsupported payment method.");
    }
}