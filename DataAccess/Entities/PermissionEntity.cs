using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(PermissionEntity.Name), IsUnique = true)]
public class PermissionEntity
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<RoleEntity> Roles { get; set; }

    public bool AllowedOnGuest { get; set; }
}