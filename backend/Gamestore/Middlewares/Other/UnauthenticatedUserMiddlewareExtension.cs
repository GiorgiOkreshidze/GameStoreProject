namespace Gamestore.Middlewares.Other;

public static class UnauthenticatedUserMiddlewareExtension
{
    public static IApplicationBuilder UnauthenticatedUserMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<UnauthenticatedUserMiddleware>();
    }
}