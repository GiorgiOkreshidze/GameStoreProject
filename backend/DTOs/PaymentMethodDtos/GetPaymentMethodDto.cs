namespace DTOs.PaymentMethodDtos;

public class GetPaymentMethodDto
{
    public ICollection<PaymentMethods> PaymentMethods { get; set; }
}