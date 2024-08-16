namespace BusinessLogic.Models;

public class Order
{
    public Guid Id { get; set; }

    public DateTime Date { get; set; }

    public DateTime RequiredDate { get; set; } = DateTime.Now;

    public DateTime ShippedDate { get; set; } = DateTime.Now;

    public int ShipVia { get; set; }

    public double Freight { get; set; }

    public string ShipName { get; set; } = string.Empty;

    public string ShipAddress { get; set; } = string.Empty;

    public string ShipCity { get; set; } = string.Empty;

    public string ShipRegion { get; set; } = string.Empty;

    public string ShipPostalCode { get; set; } = string.Empty;

    public string ShipCountry { get; set; } = string.Empty;

    public Guid CustomerId { get; set; } = Guid.Empty;

    public Enum Status { get; set; }
}