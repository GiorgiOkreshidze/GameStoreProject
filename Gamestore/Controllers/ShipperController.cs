using BusinessLogic.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class ShipperController(IShipperService shipperService) : Controller
{
    [HttpGet]
    public IActionResult GetShippers()
    {
        return Ok(shipperService.GetShippers());
    }
}