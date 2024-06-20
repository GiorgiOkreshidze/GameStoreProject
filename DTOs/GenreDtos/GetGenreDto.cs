namespace Gamestore.Dtos;

public class GetGenreDto
{
    public string Name { get; set; }
    
    public Guid? ParentGenreId { get; set; }
}