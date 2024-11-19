namespace DTOs.OrderDtos;

public class GetOrderDto
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }

    public DateTime Date { get; set; }
}