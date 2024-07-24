namespace DTOs.GameDtos;

public class UpdateGameDto
{
    public GameDtoWithId Game { get; set; }

    public ICollection<Guid> Platforms { get; set; }

    public ICollection<Guid> Genres { get; set; }

    public Guid? PublisherId { get; set; }
}