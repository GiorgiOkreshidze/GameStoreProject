namespace DataAccess.Contracts;

public interface IDataSeederDbService
{
    public Task SeedGamesDbAsync(int count);
}