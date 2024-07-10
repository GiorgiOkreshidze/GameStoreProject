using System.Diagnostics;
using Serilog;

namespace Gamestore.Middlewares.Logging;

public class RequestLoggingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();
        var originalBodyStream = context.Response.Body;

        using var responseBody = new MemoryStream();
        context.Response.Body = responseBody;

        await next(context);
        stopwatch.Stop();
        var response = await FormatResponse(context.Response);
        LogRequestDetails(context, response, stopwatch.ElapsedMilliseconds);
        await responseBody.CopyToAsync(originalBodyStream);

        // LogExceptionDetails(context, stopwatch.ElapsedMilliseconds);
    }

    private static async Task<string> FormatResponse(HttpResponse response)
    {
        response.Body.Seek(0, SeekOrigin.Begin);
        var text = await new StreamReader(response.Body).ReadToEndAsync();
        response.Body.Seek(0, SeekOrigin.Begin);
        return text;
    }

    private static void LogRequestDetails(HttpContext context, string response, long elapsedMilliseconds)
    {
        Log.Information(
            "Request {Method} {Url} => {StatusCode} in {ElapsedMilliseconds}ms\nResponse Body: {ResponseBody}",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode,
            elapsedMilliseconds,
            response);
    }

    /*private void LogExceptionDetails(HttpContext context, long elapsedMilliseconds)
    {
        Log.Error("Request {Method} {Url} => {StatusCode} in {ElapsedMilliseconds}ms\nException: {Exception}",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode,
            elapsedMilliseconds);
    }*/
}