using Microsoft.AspNetCore.Mvc;
#pragma warning disable IDE0005
using MongoDbAccess.Contracts;
#pragma warning restore IDE0005

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(IProductMongoService productMongoService, IOrderMongoService orderMongoService) : Controller
{
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        return Ok(productMongoService.GetAllMongo());
    }

    [HttpGet("orders")]
    public IActionResult GetAllOrders()
    {
        return Ok(orderMongoService.GetAllMongo());
    }
}