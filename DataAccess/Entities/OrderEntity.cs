using System.ComponentModel.DataAnnotations;
using DataAccess.Enums;

namespace DataAccess.Entities;

public class OrderEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime Date { get; set; } = DateTime.Now;

    /*public DateTime RequiredDate { get; set; } = DateTime.Now;

    public DateTime ShippedDate { get; set; } = DateTime.Now;

    public int ShipVia { get; set; }

    public double Freight { get; set; }

    public string ShipName { get; set; } = string.Empty;

    public string ShipAddress { get; set; } = string.Empty;

    public string ShipCity { get; set; } = string.Empty;

    public string ShipRegion { get; set; } = string.Empty;

    public string ShipPostalCode { get; set; } = string.Empty;

    public string ShipCountry { get; set; } = string.Empty;*/

    [Required]
    public Guid CustomerId { get; set; } = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6");

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Open;

#pragma warning disable SA1010
    public ICollection<GameEntity> GameEntities { get; set; } = [];
#pragma warning restore SA1010
}
