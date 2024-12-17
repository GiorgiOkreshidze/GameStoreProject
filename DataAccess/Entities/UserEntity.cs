using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(UserEntity.Name), IsUnique = true)]
public class UserEntity
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PasswordHash { get; set; }
    
    [Required]
    public string Email { get; set; }

    public ICollection<RoleEntity> Roles { get; set; }

    public ICollection<NotificationMethodEntity> NotificationPreferences { get; set; }
}