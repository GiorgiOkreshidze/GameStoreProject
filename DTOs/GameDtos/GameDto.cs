namespace DTOs.GameDtos;

public class GameDto
{
    public string Name { get; set; }

    public string Key { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public int UnitInStock { get; set; }

    public int Discount { get; set; }

    public string QuantityPerUnit { get; set; } = string.Empty;

    public int UnitsOnOrder { get; set; }

    public int ReorderLevel { get; set; }
}