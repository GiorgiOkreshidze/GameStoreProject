#pragma warning disable IDE0005
using BusinessLogic.Contracts;
using DTOs.RoleDtos;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleController(IRoleService roleService) : Controller
{
    [HttpGet]
    [Authorize(Policy = "RequireGetAllRolesPermission")]
    public IActionResult GetAllRoles()
    {
        return Ok(roleService.GetAllRoles());
    }

    [HttpGet("{id}")]
    [Authorize(Policy = "RequireGetRoleByIdPermission")]
    public IActionResult GetRoleById(Guid id)
    {
        var role = roleService.GetRoleById(id);
        return role is null ? NotFound(new { Message = "Role not found" }) : Ok(role);
    }

    [HttpDelete("{id}")]
    [Authorize(Policy = "RequireDeleteRoleByIdPermission")]
    public IActionResult DeleteRoleById(Guid id)
    {
        var result = roleService.DeleteRoleById(id);
        return !result ? NotFound(new { Message = "Role not found" }) : Ok(new { Message = "Role deleted successfully" });
    }

    [HttpGet("permissions")]
    [Authorize(Policy = "RequireGetAllPermissionsPermission")]
    public IActionResult GetAllPermissions()
    {
        return Ok(roleService.GetAllPermissions());
    }

    [HttpGet("{id}/permissions")]
    [Authorize(Policy = "RequireGetPermissionsByRoleIdPermission")]
    public IActionResult GetPermissionsByRoleId(Guid id)
    {
        return Ok(roleService.GetPermissionsByRoleId(id));
    }

    [HttpPost]
    [Authorize(Policy = "RequireAddRolePermission")]
    public IActionResult AddRole(AddRoleDto roleDto)
    {
        roleService.AddRole(roleDto);
        return Ok();
    }

    [HttpPut]
    [Authorize(Policy = "RequireUpdateRolePermission")]
    public IActionResult UpdateRole(UpdateRoleDto roleDto)
    {
        roleService.UpdateRole(roleDto);
        return Ok();
    }
}