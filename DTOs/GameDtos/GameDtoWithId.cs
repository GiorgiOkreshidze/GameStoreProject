namespace DTOs.GameDtos;

public class GameDtoWithId
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Key { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public int UnitInStock { get; set; }

    public int Discount { get; set; }
}