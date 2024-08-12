using Microsoft.AspNetCore.Mvc;
using MongoDbAccess.Models;
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

    [HttpPost("createProduct")]
    public IActionResult CreateProduct(ProductDocument product)
    {
        productMongoService.CreateProduct(product);
        return Ok();
    }

    [HttpPost("products/{id}")]
    public IActionResult GetProductById(string id)
    {
        return Ok(productMongoService.GetProductByIdMongo(id));
    }

    [HttpPut("products/update")]
    public IActionResult UpdateProduct(ProductDocument productDocument)
    {
        productMongoService.UpdateProduct(productDocument);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteProduct(string id)
    {
        productMongoService.DeleteProduct(id);
        return Ok();
    }
}