using System.Text.Json.Serialization;
using DTOs.CustomConvertor;

namespace DTOs.GameDtos;

public class GameFilterDto
{
    [JsonConverter(typeof(NullableGuidConverter))]
    public List<Guid> GenreIds { get; set; }

    [JsonConverter(typeof(NullableGuidConverter))]
    public List<Guid> PlatformIds { get; set; }

    [JsonConverter(typeof(NullableGuidConverter))]
    public List<Guid> PublisherIds { get; set; }

    public double? MinPrice { get; set; }

    public double? MaxPrice { get; set; }

    public DateTime? PublishDate { get; set; }

    public string Name { get; set; }

    public string PublishDateRange { get; set; }
}