namespace DTOs.GenreDtos;

public class CreateGenreDto
{
    public GGenreDto Genre { get; set; }
}

#pragma warning disable SA1402
public class GGenreDto
#pragma warning restore SA1402
{
    public Guid? ParentGenreId { get; set; }

    public string Name { get; set; }
}