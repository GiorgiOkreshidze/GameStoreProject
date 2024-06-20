using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class GenreEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }
    
    public Guid? ParentGenreId { get; set; }

    public GenreEntity? ParentGenre { get; set; }
    public ICollection<GameEntity> GameEntities { get; set; }
}