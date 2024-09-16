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
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetBanDurations", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGames", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGameByKey", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGameById", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGenresOfGame", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPlatformsOfGame", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPublisherOfGame", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DownloadGameFile", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetComments", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPaginationOptions", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetSortingOptions", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllGames", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllGenres", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGenre", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByGenreId", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetSubGenres", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetDateFilterOptions", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllOrders", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetOrders", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetOrderById", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllOrdersDetails", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetCart", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPaymentMethods", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPlatforms", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPlatformById", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByPlatformId", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPublisherByCompanyName", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPublishers", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetGamesByPublisherName", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Games", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Genres", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Platforms", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Publishers", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Orders", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Game", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Genre", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Platform", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Publisher", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Order", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Comments", AllowedOnGuest = true },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Comment", AllowedOnGuest = true },

            // User Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddComment", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddGameInCart", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Buy", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGameFromCart", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Payment", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddGameToOrderByKey", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ShipOrder", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Basket", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ReplyComment", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "QuoteComment", AllowedOnGuest = false },

            // Moderator Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "BanUser", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteComment", AllowedOnGuest = false },

            // Manager Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreateGame", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateGame", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGame", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreateGenre", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateGenre", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteGenre", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateOrderDetailQuantity", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteOrderDetails", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreatePlatform", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdatePlatform", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeletePlatform", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CreatePublisher", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdatePublisher", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeletePublisher", AllowedOnGuest = false },

            // Admin Additional Permissions
            new PermissionEntity { Id = Guid.NewGuid(), Name = "SeeDeletedGames", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllRoles", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetRoleById", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteRoleById", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllPermissions", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetPermissionsByRoleId", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddRole", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateRole", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetAllUsers", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetUserById", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteUserById", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "AddUser", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateUser", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "GetRolesOfUser", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ManageDeletedGames", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "ManageAllComments", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "History", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Users", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "User", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Roles", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "Role", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteUser", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteRole", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "CanSeeDeletedGames", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "UpdateOrder", AllowedOnGuest = false },
            new PermissionEntity { Id = Guid.NewGuid(), Name = "DeleteOrder", AllowedOnGuest = false },
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
            "GetOrders",
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
            "History",
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
            "Basket",
            "ReplyComment",
            "QuoteComment"
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
            "ManageAllComments",
            "Users",
            "User",
            "Roles",
            "Role",
            "DeleteUser",
            "DeleteRole",
            "UpdateOrder",
            "DeleteOrder"
        ]).ToList();
        foreach (var permission in permissions.Where(p => adminPermissions.Contains(p.Name)))
        {
            rolePermissions.Add(new PermissionRole { RoleEntityId = adminRoleId, PermissionEntityId = permission.Id });
        }

        // Seed permissions and role-permission relationships
        modelBuilder.Entity<PermissionEntity>().HasData(permissions);
        modelBuilder.Entity<PermissionRole>().HasData([.. rolePermissions]);

        // Seed Admin user
        var adminUserId = Guid.NewGuid();
        modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = adminUserId,
                    Name = "Admin",
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin"),
                });
        modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                RoleEntityId = adminRoleId,
                UserEntityId = adminUserId,
            });

        base.OnModelCreating(modelBuilder);
    }
}