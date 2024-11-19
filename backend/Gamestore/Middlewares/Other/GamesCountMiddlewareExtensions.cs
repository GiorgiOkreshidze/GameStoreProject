namespace Gamestore.Middlewares.Other;

public static class GamesCountMiddlewareExtensions
{
    public static IApplicationBuilder UseGamesCountMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GamesCountMiddleware>();
    }
}