using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(GenreEntity.Name), IsUnique = true)]
public class GenreEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public string Picture { get; set; }

    public Guid? ParentGenreId { get; set; }

    public GenreEntity? ParentGenre { get; set; }

    public ICollection<GameEntity> GameEntities { get; set; }
}