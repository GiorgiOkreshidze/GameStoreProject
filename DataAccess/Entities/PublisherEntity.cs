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

    /*public string ContactName { get; set; } = string.Empty;

    public string ContactTitle { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Fax { get; set; } = string.Empty;*/

    public string HomePage { get; set; }

    public string Description { get; set; }

    public ICollection<GameEntity> GameEntities { get; set; }
}