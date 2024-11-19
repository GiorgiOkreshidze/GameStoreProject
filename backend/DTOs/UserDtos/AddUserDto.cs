namespace DTOs.UserDtos;

public class AddUserDto
{
    public UserDto User { get; set; }

    public ICollection<Guid> Roles { get; set; }

    public string Password { get; set; }
}