using System.Text.Json.Serialization;
using DTOs.CustomConvertor;

namespace DTOs.GenreDtos;

public class GenreDtoWithParentId
{
    [JsonConverter(typeof(NullableGuidConverter))]
    public Guid? ParentGenreId { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Picture { get; set; } = string.Empty;

    public string Name { get; set; }
}