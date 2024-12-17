#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.UserDtos;
#pragma warning restore IDE0005
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BusinessLogic.HelperFunctions;
using DTOs.NotificationDtos;
using DTOs.RoleDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController(
    IUserService userService,
    IAccessService accessService,
    IConfiguration configuration,
    INotificationsService notificationsService) : Controller
{
    [HttpPost("login")]
    public IActionResult Login(LoginDto loginDto)
    {
        if (userService.UserNameNotExists(loginDto.Model.Login))
        {
            return BadRequest("User name not exists");
        }

        if (!userService.CheckPassword(loginDto))
        {
            return BadRequest("User password is incorrect");
        }

        var permissions = userService.GetPermissionsOfUserByName(loginDto.Model.Login);

        var roles = userService.GetRolesOfUserByName(loginDto.Model.Login);

        var token = CreateToken(loginDto, roles, permissions);

        return Ok(token);
    }

    [HttpPost("access")]
    public IActionResult Access(AccessDto accessDto)
    {
        return Ok(accessService.HasAccess(accessDto));
    }

    [HttpGet]
    [Authorize(Policy = "RequireGetAllUsersPermission")]
    public IActionResult GetAllUsers()
    {
        return Ok(userService.GetAllUsers());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGetUserByIdPermission")]
    public IActionResult GetUserById(Guid id)
    {
        var user = userService.GetUserById(id);
        return user is null ? NotFound(new { Message = "User not found" }) : Ok(user);
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "RequireDeleteUserByIdPermission")]
    public IActionResult DeleteUserById(Guid id)
    {
        try
        {
            var result = userService.DeleteUserById(id);
            return !result ? NotFound(new { Message = "User not found" }) : Ok(new { Message = "User deleted successfully" });
        }
        catch (Exception)
        {
            return new ContentResult
            {
                StatusCode = StatusCodes.Status403Forbidden,
                Content = "You do not have permission to Admin.",
                ContentType = "text/plain",
            };
        }
    }

    [HttpPost]
    [Authorize(Policy = "RequireAddUserPermission")]
    public IActionResult AddUser(AddUserDto userDto)
    {
        var result = userService.AddUser(userDto);

        return !result ? Conflict(new { Message = "User not added due to conflict" }) : Ok(new { Message = "User added successfully" });
    }

    [HttpPut]
    [Authorize(Policy = "RequireUpdateUserPermission")]
    public IActionResult UpdateUser(UpdateUserDto userDto)
    {
        var result = userService.UpdateUser(userDto);

        return !result ? NotFound(new { Message = "User not found" }) : Ok(new { Message = "User updated successfully" });
    }

    [HttpGet("{id}/roles")]
    [Authorize(Policy = "RequireGetRolesOfUserPermission")]
    public IActionResult GetRolesOfUser(Guid id)
    {
        var roles = userService.GetRolesOfUser(id);

        return roles is null ? NotFound(new { Message = "User not found" }) : Ok(roles);
    }

    [HttpGet("notifications")]
    public async Task<IActionResult> GetNotificationMethodsAsync()
    {
        var notificationMethods = await notificationsService.GetNotificationMethodsAsync();
        return Ok(notificationMethods);
    }

    [HttpGet("my/notifications")]
    [Authorize]
    public async Task<IActionResult> GetUsersNotificationMethodsAsync()
    {
        var userName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
        var userNotificationMethods = await notificationsService.GetUserNotificationMethodsAsync(userName);
        return Ok(userNotificationMethods);
    }

    [HttpPut("notifications")]
    [Authorize]
    public IActionResult UpdateUserSelectedNotifications([FromBody] NotificationPreferenceUpdateDto notificationDto)
    {
        var userName = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
        notificationsService.UpdateUserSelectedNotifications(notificationDto, userName);
        return Ok();
    }

    private TokenDto CreateToken(LoginDto login, ICollection<GetRoleDto> roles, ICollection<GetPermissionDto> permissionDtos)
    {
        List<Claim> claims =
        [
            new Claim(ClaimTypes.Name, login.Model.Login),
        ];
        claims.AddRange(roles.Select(roleDto => new Claim(ClaimTypes.Role, roleDto.Name)));
        claims.AddRange(permissionDtos.Select(permissionDto => new Claim("Permission", permissionDto.Name)));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            configuration.GetSection("Jwt:Key").Value!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddMonths(1),
            signingCredentials: creds);

        var tokenDto = new TokenDto()
        {
            Token = "bearer " + new JwtSecurityTokenHandler().WriteToken(token),
        };

        return tokenDto;
    }
}