namespace BusinessLogic.Models;

public class OrderGameModel
{
    public Guid OrderId { get; set; }

    public Guid ProductId { get; set; }

    public double Price { get; set; }

    public int Quantity { get; set; }

    public int Discount { get; set; }
}