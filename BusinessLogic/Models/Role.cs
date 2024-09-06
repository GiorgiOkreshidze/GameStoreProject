namespace BusinessLogic.Models;

public class Role
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<string> Premissions { get; set; }
}