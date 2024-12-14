namespace BusinessLogic.Contracts;

public interface IDataSeederService
{
    public Task SeedGamesAsync(int count);
}