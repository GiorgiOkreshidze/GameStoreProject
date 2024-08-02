using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class BannedUserEntity
{
    [Key]
    public string User { get; set; }

    [Required]
    public string Duration { get; set; }
}