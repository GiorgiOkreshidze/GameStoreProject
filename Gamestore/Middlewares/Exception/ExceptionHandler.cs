#pragma warning disable IDE0005
using BusinessLogic.Exceptions;
#pragma warning restore IDE0005
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Gamestore.Middlewares.Exception;

public class ExceptionHandler(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (System.Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private static async ValueTask<bool> HandleExceptionAsync(HttpContext httpContext, System.Exception exception)
    {
        var problemDetails = new ProblemDetails
        {
            Instance = httpContext.Request.Path,
        };

        if (exception is BaseException e)
        {
            httpContext.Response.StatusCode = (int)e.StatusCode;
            problemDetails.Title = e.Message;
            LogExceptionDetails(httpContext, e);
        }
        else if (exception is GenreNotExistsException e1)
        {
            httpContext.Response.StatusCode = (int)e1.StatusCode;
            problemDetails.Title = e1.Message;
            LogExceptionDetails(httpContext, e1);
        }
        else if (exception is GenreNameExistsException e2)
        {
            httpContext.Response.StatusCode = (int)e2.StatusCode;
            problemDetails.Title = e2.Message;
            LogExceptionDetails(httpContext, e2);
        }
        else if (exception is PlatformNotExistsException e3)
        {
            httpContext.Response.StatusCode = (int)e3.StatusCode;
            problemDetails.Title = e3.Message;
            LogExceptionDetails(httpContext, e3);
        }
        else if (exception is GameNotExistsException e4)
        {
            httpContext.Response.StatusCode = (int)e4.StatusCode;
            problemDetails.Title = e4.Message;
            LogExceptionDetails(httpContext, e4);
        }
        else
        {
            problemDetails.Title = exception.Message;
            LogExceptionDetails(httpContext, exception);
        }

        problemDetails.Status = httpContext.Response.StatusCode;

        await httpContext.Response.WriteAsJsonAsync(problemDetails).ConfigureAwait(false);

        return true;
    }

    private static void LogExceptionDetails(HttpContext context, System.Exception ex)
    {
        Log.Error(
            ex,
            "Request {Method} {Url} => {StatusCode} in ms\nException Type: {ExceptionType}\nException Message: {ExceptionMessage}\nInner Exceptions: {InnerExceptions}\nException Details: {ExceptionDetails}\nStack Trace: {StackTrace}",
            context.Request.Method,
            context.Request.Path,
            context.Response.StatusCode,
            ex.GetType().FullName,
            ex.Message,
            GetAllInnerExceptions(ex),
            ex.ToString(),
            ex.StackTrace);
    }

    private static string GetAllInnerExceptions(System.Exception ex)
    {
        var innerExceptionMessages = string.Empty;
        var innerEx = ex.InnerException;
        while (innerEx != null)
        {
            innerExceptionMessages += $"Inner Exception Type: {innerEx.GetType().FullName}\nInner Exception Message: {innerEx.Message}\n";
            innerEx = innerEx.InnerException;
        }

        return innerExceptionMessages;
    }
}
