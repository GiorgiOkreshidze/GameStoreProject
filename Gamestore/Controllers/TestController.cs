using Microsoft.AspNetCore.Mvc;
#pragma warning disable IDE0005
using MongoDbAccess.Contracts;
#pragma warning restore IDE0005

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController(IProductMongoService productMongoService) : Controller
{
    [HttpPost]
    public IActionResult Transfer()
    {
        return Ok(productMongoService.GetAllMongo());
    }
}