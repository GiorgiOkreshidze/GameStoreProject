using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class GamePlatform
{
    public Guid GameEntityId { get; set; }
    public Guid PlatformEntityId { get; set; }
    
    // Test
}