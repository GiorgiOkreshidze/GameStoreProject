#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.CommentDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController(ICommentService commentService) : Controller
{
    [HttpGet("ban/durations")]
    public IActionResult GetBanDurations()
    {
        return Ok(new List<string> { "1 Hour", "1 Day", "1 Week", "1 Month", "Permanent" });
    }

    [HttpPost("ban")]
    public IActionResult BanUser(BanUserDto banUserDto)
    {
        commentService.BanUser(banUserDto);
        return Ok();
    }
}