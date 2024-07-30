using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext;

public class GameDbContext(DbContextOptions<GameDbContext> options) : DbContext(options)
{
    public DbSet<GameEntity> GameEntities { get; set; }

    public DbSet<PlatformEntity> PlatformEntities { get; set; }

    public DbSet<GenreEntity> GenreEntities { get; set; }

    public DbSet<GameGenre> GameGenres { get; set; }

    public DbSet<GamePlatform> GamePlatforms { get; set; }

    public DbSet<PublisherEntity> PublisherEntities { get; set; }

    public DbSet<OrderEntity> OrderEntities { get; set; }

    public DbSet<OrderGame> OrderGames { get; set; }

    public DbSet<PaymentMethod> PaymentMethods { get; set; }

    public DbSet<CommentEntity> CommentEntities { get; set; }

    public DbSet<BanEntity> BanEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameEntity>()
            .HasMany(g => g.GenreEntities)
            .WithMany(ge => ge.GameEntities)
            .UsingEntity<GameGenre>(
                l => l.HasOne<GenreEntity>().WithMany().HasForeignKey(e => e.GenreEntityId),
                r => r.HasOne<GameEntity>().WithMany().HasForeignKey(e => e.GameEntityId));

        modelBuilder.Entity<GameEntity>()
            .HasMany(g => g.PlatformEntities)
            .WithMany(ge => ge.GameEntities)
            .UsingEntity<GamePlatform>(
                l => l.HasOne<PlatformEntity>().WithMany().HasForeignKey(e => e.PlatformEntityId),
                r => r.HasOne<GameEntity>().WithMany().HasForeignKey(e => e.GameEntityId));

        modelBuilder.Entity<GameEntity>()
            .HasOne(g => g.PublisherEntity)
            .WithMany(p => p.GameEntities)
            .HasForeignKey(g => g.PublisherId);

        modelBuilder.Entity<GenreEntity>()
            .HasOne(x => x.ParentGenre)
            .WithMany()
            .HasForeignKey(x => x.ParentGenreId);

        modelBuilder.Entity<GameEntity>()
            .HasMany(g => g.OrderEntities)
            .WithMany(ge => ge.GameEntities)
            .UsingEntity<OrderGame>(
                l => l.HasOne<OrderEntity>().WithMany().HasForeignKey(e => e.OrderId),
                r => r.HasOne<GameEntity>().WithMany().HasForeignKey(e => e.ProductId));

        modelBuilder.Entity<CommentEntity>()
            .HasOne(x => x.ParentComment)
            .WithMany()
            .HasForeignKey(x => x.ParentCommentId);

        modelBuilder.Entity<PlatformEntity>().HasData(
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Mobile" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Browser" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Desktop" },
            new PlatformEntity { Id = Guid.NewGuid(), Type = "Console" });

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
            new GenreEntity { Id = Guid.NewGuid(), Name = "Puzzle & Skill", ParentGenreId = null });

        modelBuilder.Entity<PaymentMethod>().HasData(
            new PaymentMethod { Title = "Bank", Description = "Bank Method Description", ImageUrl = "Bank Method URL" },
            new PaymentMethod { Title = "IBox terminal", Description = "IBox Terminal Method Description", ImageUrl = "IBox Terminal Method URL" },
            new PaymentMethod { Title = "Visa", Description = "Visa Method Description", ImageUrl = "Visa Method URL" });

        modelBuilder.Entity<BanEntity>().HasData(
            new BanEntity { Duration = "1 hour" },
            new BanEntity { Duration = "1 day" },
            new BanEntity { Duration = "1 week" },
            new BanEntity { Duration = "1 month" },
            new BanEntity { Duration = "permanent" });

        base.OnModelCreating(modelBuilder);
    }
}