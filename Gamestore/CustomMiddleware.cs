using DataAccess.Contracts;

namespace Gamestore;

public class CustomMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        context.Response.OnStarting(state => {
            var httpContext = (HttpContext)state;

        
            var gameDbService = context.RequestServices.GetService<IGameDbService>();
            string gamesCount = gameDbService.GetGamesNumber().ToString();
            httpContext.Response.Headers.Add("x-total-numbers-of-games",gamesCount);
        
            return Task.CompletedTask;
        }, context);

        await next(context);
    }
}

public static class CustomMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomMiddleware>();
    }
}