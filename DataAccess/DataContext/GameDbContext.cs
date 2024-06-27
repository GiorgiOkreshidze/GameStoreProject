using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext;

public class GameDbContext(DbContextOptions<GameDbContext> options) : DbContext(options)
{
    public DbSet<GameEntity> GameEntities { get; set; }
    public DbSet<PlatformEntity> PlatformEntities { get; set; }
    public DbSet<GenreEntity> GenreEntities { get; set; }   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameEntity>()
            .HasMany(x => x.PlatformEntities)
            .WithMany(x => x.GameEntities)
            .UsingEntity(j => j.ToTable("GamePlatform"));
        
        
        modelBuilder.Entity<GenreEntity>()
            .HasMany(x => x.GameEntities)
            .WithMany(x => x.GenreEntities)
            .UsingEntity(j => j.ToTable("GameGenre"));
        // we need to specify on delete behaviour
        
        // This is questionable 
        modelBuilder.Entity<GenreEntity>()
            .HasOne(x => x.ParentGenre)
            .WithMany()
            .HasForeignKey(x => x.ParentGenreId);
        
        modelBuilder.Entity<PlatformEntity>().HasData(
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Mobile" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Browser" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Desktop" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Console" }
        );
        
        var strategyId = Guid.NewGuid();
        var racesId = Guid.NewGuid();
        var actionId = Guid.NewGuid();

        modelBuilder.Entity<GenreEntity>().HasData(
            new GenreEntity { Id = strategyId, Name = "Strategy", ParentGenreId = null },
            new GenreEntity { Id = Guid.NewGuid(), Name = "RTS", ParentGenreId = strategyId },
            new GenreEntity { Id = Guid.NewGuid(), Name = "TBS", ParentGenreId = strategyId },
            
            new GenreEntity { Id = Guid.NewGuid(), Name = "RPG", ParentGenreId = null },
            
            new GenreEntity { Id = Guid.NewGuid(), Name = "Sports", ParentGenreId = null },
            
            new GenreEntity { Id = racesId, Name = "Races", ParentGenreId = null },
            new GenreEntity { Id = Guid.NewGuid(), Name = "Rally", ParentGenreId = racesId },
            new GenreEntity { Id = Guid.NewGuid(), Name = "Arcade", ParentGenreId = racesId },
            new GenreEntity { Id = Guid.NewGuid(), Name = "Formula", ParentGenreId = racesId },
            new GenreEntity { Id = Guid.NewGuid(), Name = "Off-road", ParentGenreId = racesId },
            
            
            new GenreEntity { Id = actionId, Name = "Action", ParentGenreId = null },
            new GenreEntity { Id = Guid.NewGuid(), Name = "FPS", ParentGenreId = actionId },
            new GenreEntity { Id = Guid.NewGuid(), Name = "TPS", ParentGenreId = actionId },
            
            new GenreEntity { Id = Guid.NewGuid(), Name = "Adventure", ParentGenreId = null },
            new GenreEntity { Id = Guid.NewGuid(), Name = "Puzzle & Skill", ParentGenreId = null }
            
        );
        
        base.OnModelCreating(modelBuilder);
    }
}