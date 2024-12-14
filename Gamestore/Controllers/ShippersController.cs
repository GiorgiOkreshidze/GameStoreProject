using BusinessLogic.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class ShippersController(IShipperService shipperService) : Controller
{
    [HttpGet]
    [Authorize(Policy = "RequireGetShippersPermission")]
    public IActionResult GetShippers()
    {
        return Ok(shipperService.GetShippers());
    }
}