namespace DTOs.GenreDtos;

public class GenreDtoWithParentId
{
    public Guid? ParentGenreId { get; set; }

    public string Name { get; set; }
}