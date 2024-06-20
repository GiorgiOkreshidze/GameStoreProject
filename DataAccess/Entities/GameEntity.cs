using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class GameEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Key { get; set; }

    public string description { get; set; }

    public ICollection<PlatformEntity> PlatformEntities { get; set; }
    
    public ICollection<GenreEntity> GenreEntities { get; set; }
}