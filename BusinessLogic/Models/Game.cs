namespace BusinessLogic.Models;

public class Game
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Key { get; set; }

    public string Description { get; set; }
    
    public ICollection<Guid> Platforms { get; set; }
    
    public ICollection<Guid> Genres { get; set; }
}