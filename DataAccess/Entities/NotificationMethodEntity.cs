using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(NotificationMethodEntity.Type), IsUnique = true)]
public class NotificationMethodEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Type { get; set; }

    public ICollection<UserEntity> UserEntities { get; set; }
}