namespace Gamestore.Dtos;

public class GetGameDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public string Key { get; set; }

    public string description { get; set; }
}