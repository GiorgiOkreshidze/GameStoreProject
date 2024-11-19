namespace DTOs.RoleDtos;

public class AddRoleDto
{
    public RoleDto Role { get; set; }

    public ICollection<string> Permissions { get; set; }
}