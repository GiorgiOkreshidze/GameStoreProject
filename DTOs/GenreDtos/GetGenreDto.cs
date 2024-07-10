namespace DTOs.GenreDtos;

public class GetGenreDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public Guid? ParentGenreId { get; set; }
}