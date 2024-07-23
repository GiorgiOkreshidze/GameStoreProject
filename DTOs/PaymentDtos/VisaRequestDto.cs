using System.ComponentModel.DataAnnotations;

namespace DTOs.PaymentDtos;

public class VisaRequestDto
{
    public int TransactionAmount { get; set; }

    public string CardHolderName { get; set; }

    [RegularExpression(@"^4\d{15}$", ErrorMessage = "Visa card number must start with 4 and contain exactly 16 digits.")]
    public string CardNumber { get; set; }

    [Range(1, 12, ErrorMessage = "Expiration month must be between 1 and 12.")]
    public int ExpirationMonth { get; set; }

    [Range(1, 999, ErrorMessage = "CVV must be between 1 and 999.")]
    public int Cvv { get; set; }

    [Range(1960, int.MaxValue, ErrorMessage = "Expiration year must be between 1960 and 2147483647.")]
    public int ExpirationYear { get; set; }
}