namespace DTOs.PaymentDtos;

public class IBoxTerminalResponseDto
{
    public Guid UserId { get; set; }

    public Guid OrderId { get; set; }

    public DateTime PaymentDate { get; set; }

    public int Sum { get; set; }
}