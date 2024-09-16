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

    public ICollection<RoleEntity> Roles { get; set; }
}