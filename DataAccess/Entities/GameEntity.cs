using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(GameEntity.Key), IsUnique = true)]
public class GameEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Key { get; set; }

    public string Description { get; set; }

    [Required]
    public double Price { get; set; }

    [Required]
    public int UnitInStock { get; set; }

    [Required]
    public int Discount { get; set; }

    [Required]
    public Guid? PublisherId { get; set; }

    public PublisherEntity PublisherEntity { get; set; }

    public ICollection<PlatformEntity> PlatformEntities { get; set; }

    public ICollection<GenreEntity> GenreEntities { get; set; }

    public ICollection<OrderEntity> OrderEntities { get; set; }
}