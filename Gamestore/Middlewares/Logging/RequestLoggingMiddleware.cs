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
        var requestBody = await ReadRequestBody(context.Request);
        var response = await ReadResponseBody(context.Response);
        LogRequestDetails(context, requestBody, response, stopwatch.ElapsedMilliseconds);
        await responseBody.CopyToAsync(originalBodyStream);
    }

    private static async Task<string> ReadResponseBody(HttpResponse response)
    {
        response.Body.Seek(0, SeekOrigin.Begin);
        var body = await new StreamReader(response.Body).ReadToEndAsync();
        response.Body.Seek(0, SeekOrigin.Begin);
        return body;
    }

    private static void LogRequestDetails(HttpContext context, string requestBody, string responseBody, long elapsedMilliseconds)
    {
        Log.Information(
            "Request {Method} {Url} from {IpAddress} => {StatusCode} in {ElapsedMilliseconds}ms\nRequest Body: {RequestBody}\nResponse Body: {ResponseBody}",
            context.Request.Method,
            context.Request.Path,
            context.Connection.RemoteIpAddress,
            context.Response.StatusCode,
            elapsedMilliseconds,
            requestBody,
            responseBody);
    }

    private static async Task<string> ReadRequestBody(HttpRequest request)
    {
        request.EnableBuffering();
        var body = await new StreamReader(request.Body).ReadToEndAsync();
        return body;
    }
}