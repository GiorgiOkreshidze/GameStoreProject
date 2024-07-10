using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class GamePlatform
{
    public Guid GameEntityId { get; set; }
    /*public GameEntity GameEntity { get; set; }*/
    

    public Guid PlatformEntityId { get; set; }
    /*public PlatformEntity PlatformEntity { get; set; }*/
}