using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class PaymentMethod
{
    [Key]
    public string Title { get; set; }

    public string Description { get; set; }

    [Required]
    public string Url { get; set; }
}