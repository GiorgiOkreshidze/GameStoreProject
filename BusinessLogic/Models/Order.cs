namespace BusinessLogic.Models;

public class Order
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public Guid CustomerId { get; set; } = Guid.Empty;

    public Enum Status { get; set; }
}