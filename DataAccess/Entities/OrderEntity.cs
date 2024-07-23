using System.ComponentModel.DataAnnotations;
using DataAccess.Enums;

namespace DataAccess.Entities;

public class OrderEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime Date { get; set; } = DateTime.Now;

    [Required]
    public Guid CustomerId { get; set; } = Guid.Empty;

    [Required]
    public OrderStatus Status { get; set; } = OrderStatus.Open;

#pragma warning disable SA1010
    public ICollection<GameEntity> GameEntities { get; set; } = [];
#pragma warning restore SA1010
}
