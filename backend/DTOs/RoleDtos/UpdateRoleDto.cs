namespace DTOs.RoleDtos;

public class UpdateRoleDto
{
    public RoleDtoWithId Role { get; set; }

    public ICollection<string> Permissions { get; set; }
}