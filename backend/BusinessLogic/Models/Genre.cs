namespace BusinessLogic.Models;

public class Genre
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Picture { get; set; } = string.Empty;

    public Guid? ParentGenreId { get; set; }
}