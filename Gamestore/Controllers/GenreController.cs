using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

public class GenreController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}