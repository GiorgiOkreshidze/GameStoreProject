using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(PublisherEntity.CompanyName), IsUnique = true)]
public class PublisherEntity
{
    [Key] 
    public Guid Id { get; set; }

    [Required]
    public string CompanyName { get; set; }

    public string HomePage { get; set; }

    public string Description { get; set; }
    
    public ICollection<GameEntity> GameEntities { get; set; }
}