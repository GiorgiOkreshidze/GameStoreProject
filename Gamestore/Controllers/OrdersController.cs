using BusinessLogic.Contracts;
#pragma warning disable IDE0005
using DTOs.OrderDtos;
#pragma warning restore IDE0005
using DTOs.PaymentDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController(IOrderService orderService) : Controller
{
    [HttpGet("history")]
    [Authorize(Policy = "RequireGetAllOrdersPermission")]
    public IActionResult GetAllOrders([FromQuery] IntervalDto intervalDto)
    {
        return Ok(orderService.GetAllOrders(intervalDto));
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetOrdersPermission")]
    public IActionResult GetOrders()
    {
        return Ok(orderService.GetOrders());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGetOrderByIdPermission")]
    public IActionResult GetOrderById(Guid id)
    {
        return Ok(orderService.GetOrderById(id));
    }

    [HttpGet("{id}/details")]
    [Authorize(Policy = "RequireGetAllOrdersDetailsPermission")]
    public IActionResult GetAllOrdersDetails(Guid id)
    {
        return Ok(orderService.GetAllOrdersDetails(id));
    }

    [HttpDelete("cart/{key}")]
    [Authorize(Policy = "RequireDeleteGameFromCartPermission")]
    public IActionResult DeleteGameFromCart(string key)
    {
        orderService.DeleteGameFromCart(key);
        return Ok();
    }

    [HttpGet("cart")]
    [Authorize(Policy = "RequireGetCartPermission")]
    public IActionResult GetCart()
    {
        return Ok(orderService.GetCart());
    }

    [HttpGet("payment-methods")]
    [Authorize(Policy = "RequireGetPaymentMethodsPermission")]
    public IActionResult GetPaymentMethods()
    {
        return Ok(orderService.GetPaymentMethods());
    }

    [HttpPost("payment")]
    [Authorize(Policy = "RequirePaymentPermission")]
    public IActionResult Payment(PaymentDto paymentDto)
    {
        if (paymentDto.Method == "Bank")
        {
            var (fileBytes, fileName) = orderService.PaymentByBank(paymentDto);
            return File(fileBytes, "application/pdf", fileName);
        }

        if (paymentDto.Method == "IBox terminal")
        {
            return Ok(orderService.PaymentByIBoxTermianl());
        }

        if (paymentDto.Method == "Visa")
        {
            orderService.PaymentByVisa(paymentDto);
            return Ok();
        }

        return BadRequest("Unsupported payment method.");
    }

    [HttpPatch("details/{id}/quantity")]
    [Authorize(Policy = "RequireUpdateOrderDetailQuantityPermission")]
    public IActionResult UpdateOrderDetailQuantity(Guid id, CountDto countDto)
    {
        orderService.UpdateOrderDetailQuantity(id, countDto);
        return Ok();
    }

    [HttpDelete("details/{id}")]
    [Authorize(Policy = "RequireDeleteOrderDetailsPermission")]
    public IActionResult DeleteOrderDetails(Guid id)
    {
        var result = orderService.DeleteOrderDetails(id);

        return !result ? NotFound(new { Message = "Order details not found" }) : Ok(new { Message = "Order details deleted successfully" });
    }

    [HttpPost("{id}/ship")]
    [Authorize(Policy = "RequireShipOrderPermission")]
    public IActionResult ShipOrder(Guid id)
    {
        var result = orderService.ShipOrder(id);

        return !result ? NotFound(new { Message = "Order not found" }) : Ok(new { Message = "Order shipped successfully" });
    }

    [HttpPost("{id}/details/{key}")]
    [Authorize(Policy = "RequireAddGameToOrderByKeyPermission")]
    public IActionResult AddGameToOrderByKey(Guid id, string key)
    {
        var result = orderService.AddGameToOrderByKey(id, key);

        return !result ? NotFound(new { Message = "game or order not found" }) : Ok(new { Message = "Game Added successfully" });
    }
}