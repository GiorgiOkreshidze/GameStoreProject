using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class PlatformEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Type { get; set; }

    public ICollection<GameEntity> GameEntities { get; set; }
}