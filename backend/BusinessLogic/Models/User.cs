namespace BusinessLogic.Models;

public class User
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PasswordHash { get; set; }

    public ICollection<Guid> Roles { get; set; }
}