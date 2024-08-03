namespace DTOs.GameDtos;

public class GameFilterDto
{
    public List<Guid>? GenreIds { get; set; }

    public List<Guid>? PlatformIds { get; set; }

    public List<Guid>? PublisherIds { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public string? Name { get; set; }

    public string? PublishDateRange { get; set; }
}