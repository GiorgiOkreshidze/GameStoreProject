using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

[Index(nameof(RoleEntity.Name), IsUnique = true)]
public class RoleEntity
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public ICollection<UserEntity> Users { get; set; }

    public ICollection<PermissionEntity> Permissions { get; set; }
}