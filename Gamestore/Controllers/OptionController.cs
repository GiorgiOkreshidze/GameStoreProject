using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class OptionController : Controller
{
    [HttpGet("publish-date-options")]
    public IActionResult GetDateFilterOptions()
    {
        return Ok(new List<string> { "last week", "last month", "last year", "2 years", "3 years" });
    }
}