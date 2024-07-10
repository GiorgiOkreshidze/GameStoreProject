namespace DTOs.GenreDtos;

public class UpdateGenreDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public Guid? ParentGenreId { get; set; }
}