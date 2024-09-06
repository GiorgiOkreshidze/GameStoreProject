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

    public DbSet<BannedUserEntity> BannedUserEntities { get; set; }

    public DbSet<DatabaseIds> DatabaseIdsSet { get; set; }

    public DbSet<UserEntity> UserEntities { get; set; }

    public DbSet<RoleEntity> RoleEntities { get; set; }

    public DbSet<UserRole> UserRoles { get; set; }

    public DbSet<PermissionEntity> PermissionEntities { get; set; }

    public DbSet<PermissionRole> PermissionRoles { get; set; }

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

        modelBuilder.Entity<UserEntity>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<UserRole>(
                l => l.HasOne<RoleEntity>().WithMany().HasForeignKey(e => e.RoleEntityId),
                r => r.HasOne<UserEntity>().WithMany().HasForeignKey(e => e.UserEntityId));

        modelBuilder.Entity<RoleEntity>()
            .HasMany(r => r.Permissions)
            .WithMany(p => p.Roles)
            .UsingEntity<PermissionRole>(
                l => l.HasOne<PermissionEntity>().WithMany().HasForeignKey(e => e.PermissionEntityId),
                r => r.HasOne<RoleEntity>().WithMany().HasForeignKey(e => e.RoleEntityId));

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

        // Define role Ids
        var guestRoleId = Guid.NewGuid();
        var userRoleId = Guid.NewGuid();
        var moderatorRoleId = Guid.NewGuid();
        var managerRoleId = Guid.NewGuid();
        var adminRoleId = Guid.NewGuid();

        // Define permission Ids
        var permissions = new[]
        {
            // Guest Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetBanDurations" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGames" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGameByKey" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGameById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGenresOfGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPlatformsOfGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPublisherOfGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DownloadGameFile" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetComments" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPaginationOptions" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetSortingOptions" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllGames" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllGenres" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGenre" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByGenreId" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetSubGenres" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetDateFilterOptions" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllOrders" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetOrderById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllOrdersDetails" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetCart" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPaymentMethods" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPlatforms" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPlatformById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByPlatformId" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPublisherByCompanyName" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPublishers" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByPublisherName" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Games" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Genres" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Platforms" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Publishers" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Orders" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Game" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Genre" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Platform" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Publisher" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Order" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Comments" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Comment" },

            // User Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddComment" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddGameInCart" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Buy" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGameFromCart" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Payment" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddGameToOrderByKey" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ShipOrder" },

            // Moderator Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "BanUser" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteComment" },

            // Manager Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreateGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGame" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreateGenre" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateGenre" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGenre" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateOrderDetailQuantity" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteOrderDetails" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreatePlatform" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdatePlatform" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeletePlatform" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreatePublisher" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdatePublisher" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeletePublisher" },

            // Admin Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "SeeDeletedGames" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllRoles" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetRoleById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteRoleById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPermissions" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPermissionsByRoleId" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddRole" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateRole" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllUsers" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetUserById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteUserById" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddUser" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateUser" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetRolesOfUser" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ManageDeletedGames" },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ManageAllComments" },
        };

        // Seed roles
        modelBuilder.Entity<RoleEntity>().HasData(
            new RoleEntity { Id = guestRoleId, Name = "Guest" },
            new RoleEntity { Id = userRoleId, Name = "User" },
            new RoleEntity { Id = moderatorRoleId, Name = "Moderator" },
            new RoleEntity { Id = managerRoleId, Name = "Manager" },
            new RoleEntity { Id = adminRoleId, Name = "Admin" });

        // Seed role-permission relationships
        var rolePermissions = new List<PermissionRole>();

        // Guest permissions
        var guestPermissions = new List<string>
        {
            "GetBanDurations",
            "GetGames",
            "GetGameByKey",
            "GetGameById",
            "GetGenresOfGame",
            "GetPlatformsOfGame",
            "GetPublisherOfGame",
            "DownloadGameFile",
            "GetComments",
            "GetPaginationOptions",
            "GetSortingOptions",
            "GetAllGames",
            "GetAllGenres",
            "GetGenre",
            "GetGamesByGenreId",
            "GetSubGenres",
            "GetDateFilterOptions",
            "GetAllOrders",
            "GetOrderById",
            "GetAllOrdersDetails",
            "GetCart",
            "GetPaymentMethods",
            "GetAllPlatforms",
            "GetPlatformById",
            "GetGamesByPlatformId",
            "GetPublisherByCompanyName",
            "GetAllPublishers",
            "GetGamesByPublisherName",
            "Games",
            "Genres",
            "Platforms",
            "Publishers",
            "Orders",
            "Game",
            "Genre",
            "Platform",
            "Publisher",
            "Order",
            "Comments",
            "Comment",
        };
        foreach (var permission in permissions.Where(p => guestPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = guestRoleId, PermissionEntityId = permission.Id });
        }

        // User additional permissions
        var userPermissions = guestPermissions.Concat(
        [
            "AddComment",
            "AddGameInCart",
            "Buy",
            "DeleteGameFromCart",
            "Payment",
            "AddGameToOrderByKey",
            "ShipOrder",
        ]).ToList();
        foreach (var permission in permissions.Where(p => userPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = userRoleId, PermissionEntityId = permission.Id });
        }

        // Moderator additional permissions
        var moderatorPermissions = userPermissions.Concat(
        [
            "BanUser",
            "DeleteComment",
        ]).ToList();
        foreach (var permission in permissions.Where(p => moderatorPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = moderatorRoleId, PermissionEntityId = permission.Id });
        }

        // Manager additional permissions
        var managerPermissions = moderatorPermissions.Concat(
        [
            "CreateGame",
            "UpdateGame",
            "DeleteGame",
            "CreateGenre",
            "UpdateGenre",
            "DeleteGenre",
            "UpdateOrderDetailQuantity",
            "DeleteOrderDetails",
            "CreatePlatform",
            "UpdatePlatform",
            "DeletePlatform",
            "CreatePublisher",
            "UpdatePublisher",
            "DeletePublisher"
        ]).ToList();
        foreach (var permission in permissions.Where(p => managerPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = managerRoleId, PermissionEntityId = permission.Id });
        }

        // Admin additional permissions
        var adminPermissions = managerPermissions.Concat(
        [
            "CanSeeDeletedGames",
            "GetAllRoles",
            "CanSeeDeletedGames",
            "GetAllRoles",
            "GetRoleById",
            "DeleteRoleById",
            "GetAllPermissions",
            "GetPermissionsByRoleId",
            "AddRole",
            "UpdateRole",
            "GetAllUsers",
            "GetUserById",
            "DeleteUserById",
            "AddUser",
            "UpdateUser",
            "GetRolesOfUser",
            "ManageDeletedGames",
            "ManageAllComments"
        ]).ToList();
        foreach (var permission in permissions.Where(p => adminPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = adminRoleId, PermissionEntityId = permission.Id });
        }

        // Seed permissions and role-permission relationships
        modelBuilder.Entity<PermissionEntity>().HasData(permissions);
        modelBuilder.Entity<PermissionRole>().HasData([.. rolePermissions]);

        base.OnModelCreating(modelBuilder);
    }
}