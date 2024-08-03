using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class OptionController : Controller
{
    [HttpGet]
    public IActionResult GetDateFilterOptions()
    {
        var options = new[]
        {
            new { Value = "LastWeek", Label = "Last Week" },
            new { Value = "LastMonth", Label = "Last Month" },
            new { Value = "LastYear", Label = "Last Year" },
            new { Value = "TwoYears", Label = "2 Years" },
            new { Value = "ThreeYears", Label = "3 Years" },
        };
        return Ok(options);
    }
}