namespace DTOs.UserDtos;

public class UpdateUserDto
{
    public UserDtoWithId User { get; set; }

    public ICollection<Guid> Roles { get; set; }

    public string Password { get; set; }
}