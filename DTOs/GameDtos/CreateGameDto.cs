namespace DTOs.GameDtos;

public class CreateGameDto
{
    public GameDto Game { get; set; }

    public ICollection<Guid> Genres { get; set; }

    public ICollection<Guid> Platforms { get; set; }

    public Guid? Publisher { get; set; }
}

#pragma warning disable SA1402
public class GameDto
#pragma warning restore SA1402
{
    public string Name { get; set; }

    public string Key { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public int UnitInStock { get; set; }

    public int Discount { get; set; }
}