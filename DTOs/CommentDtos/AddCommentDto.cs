using System.Text.Json.Serialization;
using DTOs.CustomConvertor;

namespace DTOs.CommentDtos;

public class AddCommentDto
{
    public CommentDto Comment { get; set; }

    [JsonConverter(typeof(NullableGuidConverter))]
    public Guid? ParentId { get; set; }

    public string Action { get; set; }
}