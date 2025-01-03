namespace BusinessLogic.Models;

public class Game
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Key { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }

    public int UnitInStock { get; set; }

    public int Discount { get; set; }

    public Guid? PublisherId { get; set; }

    public ICollection<Guid> Platforms { get; set; }

    public ICollection<Guid> Genres { get; set; }

    public string QuantityPerUnit { get; set; } = string.Empty;

    public int UnitsOnOrder { get; set; }

    public int ReorderLevel { get; set; }

    public int Views { get; set; }

    public DateTime PublishDate { get; set; } = DateTime.Now;

    public bool Deleted { get; set; }
}