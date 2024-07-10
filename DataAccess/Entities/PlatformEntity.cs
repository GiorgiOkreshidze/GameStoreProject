using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(PlatformEntity.Type), IsUnique = true)]
public class PlatformEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Type { get; set; }

    public ICollection<GameEntity> GameEntities { get; set; }
    
}