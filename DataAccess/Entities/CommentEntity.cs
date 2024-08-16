using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class CommentEntity
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Body { get; set; }

    public Guid? ParentCommentId { get; set; }

    public CommentEntity? ParentComment { get; set; }

    [Required]
    public Guid GameId { get; set; }

    public virtual GameEntity GameEntity { get; set; }
}