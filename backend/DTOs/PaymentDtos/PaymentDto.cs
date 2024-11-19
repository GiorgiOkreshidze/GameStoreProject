namespace DTOs.PaymentDtos;

public class PaymentDto
{
    public string Method { get; set; }

    public Model? Model { get; set; }
}

#pragma warning disable SA1402
public class Model
#pragma warning restore SA1402
{
    public string Holder { get; set; }

    public string CardNumber { get; set; }

    public int MonthExpire { get; set; }

    public int YearExpire { get; set; }

    public int Cvv2 { get; set; }
}