namespace DTOs.GameDtos;

public class CreateGameDto
{
    public GameDto Game { get; set; }

    public ICollection<Guid> Genres { get; set; }

    public ICollection<Guid> Platforms { get; set; }

    public Guid? Publisher { get; set; }
}