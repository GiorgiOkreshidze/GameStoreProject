using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

public class PlatformController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}