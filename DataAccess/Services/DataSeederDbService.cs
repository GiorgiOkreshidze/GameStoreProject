using System.Globalization;
using System.Text.RegularExpressions;
using Bogus;
using DataAccess.Contracts;
using DataAccess.DataContext;
using DataAccess.Entities;

namespace DataAccess.Services;

public class DataSeederDbService(GameDbContext gameDbContext) : IDataSeederDbService
{
    private static readonly Regex MyRegex = new(@"\s+", RegexOptions.Compiled);

    public async Task SeedGamesDbAsync(int count)
    {
        var existingPublishers = gameDbContext.PublisherEntities.ToList();
        var existingPlatforms = gameDbContext.PlatformEntities.ToList();
        var existingGenres = gameDbContext.GenreEntities.ToList();

        if (!existingPublishers.Any() || !existingPlatforms.Any() || !existingGenres.Any())
        {
            throw new InvalidOperationException("Ensure publishers, platforms, and genres exist before seeding games.");
        }

        var faker = new Faker<GameEntity>()
            .RuleFor(g => g.Id, f => Guid.NewGuid())
            .RuleFor(g => g.Name, f => f.Commerce.ProductName())
            .RuleFor(g => g.Key, (f, g) => GenerateKeyFromName(g.Name))
            .RuleFor(g => g.Description, f => f.Lorem.Paragraph())
            .RuleFor(g => g.Price, f => Math.Round((double)f.Finance.Amount(10, 100), 2))
            .RuleFor(g => g.UnitInStock, f => f.Random.Int(0, 1000))
            .RuleFor(g => g.Discount, f => f.Random.Int(0, 50))
            .RuleFor(g => g.QuantityPerUnit, f => $"{f.Random.Int(1, 10)} units")
            .RuleFor(g => g.UnitsOnOrder, f => f.Random.Int(0, 100))
            .RuleFor(g => g.ReorderLevel, f => f.Random.Int(0, 20))
            .RuleFor(g => g.Views, f => 0)
            .RuleFor(g => g.PublishDate, f => DateTime.Now)
            .RuleFor(g => g.Deleted, f => false)
            .RuleFor(
                g => g.PlatformEntities,
                f => f.PickRandom(existingPlatforms, f.Random.Int(1, existingPlatforms.Count)).ToList())
            .RuleFor(
                g => g.GenreEntities,
                f => f.PickRandom(existingGenres, f.Random.Int(1, existingGenres.Count)).ToList())
            .RuleFor(g => g.OrderEntities, f => [])
            .RuleFor(g => g.CommentEntities, f => [])
            .RuleFor(g => g.PublisherEntity, f => f.PickRandom(existingPublishers))
            .RuleFor(g => g.PublisherId, (f, g) => g.PublisherEntity.Id);

        const int batchSize = 1000;
        for (int i = 0; i < count; i += batchSize)
        {
            var batchCount = Math.Min(batchSize, count - i);
            var games = faker.Generate(batchCount);

            await gameDbContext.GameEntities.AddRangeAsync(games);
            await gameDbContext.SaveChangesAsync();
        }
    }

    private static string GenerateKeyFromName(string name)
    {
        var normalizedGameName = MyRegex.Replace(name, string.Empty).ToLower(CultureInfo.CurrentCulture);

        var baseKey = normalizedGameName.Length > 8 ? normalizedGameName[..8] : normalizedGameName;

        var uniqueKey = $"{baseKey}-{Guid.NewGuid():N}";
        return uniqueKey;
    }
}