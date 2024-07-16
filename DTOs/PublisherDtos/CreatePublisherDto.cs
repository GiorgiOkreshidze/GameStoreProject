namespace DTOs.PublisherDtos;

public class CreatePublisherDto
{
    public PublisherDto Publisher { get; set; }
}

#pragma warning disable SA1402
public class PublisherDto
#pragma warning restore SA1402
{
    public string CompanyName { get; set; }

    public string HomePage { get; set; }

    public string Description { get; set; }
}