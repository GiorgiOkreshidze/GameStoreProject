using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class GameGenre
{
    
    public Guid GameEntityId { get; set; }
    /*public GameEntity GameEntity { get; set; }*/
    
    public Guid GenreEntityId { get; set; }
    /*public GenreEntity GenreEntity { get; set; }*/
}