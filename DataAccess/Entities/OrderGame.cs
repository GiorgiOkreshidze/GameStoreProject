using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class OrderGame
{
    [Key]
    public Guid OrderGameId { get; set; } = Guid.NewGuid();

    [Required]
    public Guid OrderId { get; set; }

    [Required]
    public Guid ProductId { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int Quantity { get; set; }

    public int Discount { get; set; }
}