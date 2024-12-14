using BusinessLogic.Contracts;
using DataAccess.Contracts;

namespace BusinessLogic.Services;

public class DataSeederService(IDataSeederDbService dataSeederDbService) : IDataSeederService
{
    public async Task SeedGamesAsync(int count)
    {
        await dataSeederDbService.SeedGamesDbAsync(count);
    }
}