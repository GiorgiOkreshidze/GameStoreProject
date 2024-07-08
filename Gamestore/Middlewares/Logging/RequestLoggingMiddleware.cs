using System.Diagnostics;
using Serilog;

namespace Gamestore.Middlewares.Logging;

public class RequestLoggingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();
        var request = await FormatRequest(context.Request);
        var originalBodyStream = context.Response.Body;

        using (var responseBody = new MemoryStream())
        {
            context.Response.Body = responseBody;

            await next(context);
            stopwatch.Stop();
            var response = await FormatResponse(context.Response);
            LogRequestDetails(context, request, response, stopwatch.ElapsedMilliseconds);
            await responseBody.CopyToAsync(originalBodyStream);
            //LogExceptionDetails(context, stopwatch.ElapsedMilliseconds);
        }
    }

    private async Task<string> FormatRequest(HttpRequest request)
    {
        request.EnableBuffering();
        var body = request.Body;
        var buffer = new byte[Convert.ToInt32(request.ContentLength)];
        await request.Body.ReadAsync(buffer, 0, buffer.Length);
        var bodyAsText = System.Text.Encoding.UTF8.GetString(buffer);
        request.Body = body;
        return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
    }

    private async Task<string> FormatResponse(HttpResponse response)
    {
        response.Body.Seek(0, SeekOrigin.Begin);
        var text = await new StreamReader(response.Body).ReadToEndAsync();
        response.Body.Seek(0, SeekOrigin.Begin);
        return text;
    }

    private void LogRequestDetails(HttpContext context, string request, string response, long elapsedMilliseconds)
    {
        Log.Information("Request {Method} {Url} => {StatusCode} in {ElapsedMilliseconds}ms\nRequest Body: {RequestBody}\nResponse Body: {ResponseBody}",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode,
            elapsedMilliseconds,
            request,
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