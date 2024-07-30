using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class BanEntity
{
    [Key]
    public string Duration { get; set; }
}