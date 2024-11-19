namespace DTOs.PaymentDtos;

public class IBoxTerminalRequestDto
{
    public int TransactionAmount { get; set; }

    public Guid AccountNumber { get; set; }

    public Guid InvoiceNumber { get; set; }
}