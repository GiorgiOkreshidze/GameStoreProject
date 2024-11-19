namespace BusinessLogic.Models;

public class Comment
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Body { get; set; }

    public string Action { get; set; }

    public Guid? ParentCommentId { get; set; }

    public Guid GameId { get; set; }
}