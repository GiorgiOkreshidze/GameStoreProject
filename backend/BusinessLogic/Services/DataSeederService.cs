using BusinessLogic.Contracts;
#pragma warning disable IDE0005
using DataAccess.Contracts;
#pragma warning restore IDE0005

namespace BusinessLogic.Services;

public class DataSeederService(IDataSeederDbService dataSeederDbService) : IDataSeederService
{
    public async Task SeedGamesAsync(int count)
    {
        await dataSeederDbService.SeedGamesDbAsync(count);
    }
}