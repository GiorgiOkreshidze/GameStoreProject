namespace DTOs.PublisherDtos;

public class UpdatePublisherDto
{
    public Guid Id { get; set; }
    
    public string CompanyName { get; set; }

    public string HomePage { get; set; }

    public string Description { get; set; }
}