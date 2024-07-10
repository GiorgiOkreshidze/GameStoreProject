namespace DTOs.GenreDtos;

public class CreateGenreDto
{
    public string Name { get; set; }

    public Guid? ParentGenreId { get; set; }
}