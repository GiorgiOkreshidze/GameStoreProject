using DataAccess.Contracts;
using Microsoft.Extensions.Caching.Memory;

namespace Gamestore.Middlewares.Other;

public class GamesCountMiddleware(IMemoryCache cache) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var gameDbService = context.RequestServices.GetService<IGameDbService>();
        if (!cache.TryGetValue("TotalGamesCount", out int number))
        {
            number = gameDbService.GetGamesNumber();
            cache.Set("TotalGamesCount", number, TimeSpan.FromMinutes(1));
        }
        context.Response.OnStarting(state => {
            var httpContext = (HttpContext)state;

            string gamesCount = number.ToString();
            httpContext.Response.Headers.Append("x-total-numbers-of-games",gamesCount);
            
            return Task.CompletedTask;
        }, context);

        await next(context);
    }
}

public static class GamesCountMiddlewareExtensions
{
    public static IApplicationBuilder UseGamesCountMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GamesCountMiddleware>();
    }
}