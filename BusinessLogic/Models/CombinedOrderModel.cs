namespace BusinessLogic.Models;

public class CombinedOrderModel
{
    public string Id { get; set; }

    public DateTime Date { get; set; }

    public string CustomerId { get; set; } = string.Empty;
}