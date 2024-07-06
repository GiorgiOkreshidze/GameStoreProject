using BusinessLogic.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Gamestore.Middlewares.Exception;

public class ExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, System.Exception exception, CancellationToken cancellationToken)
    {
        var problemDetails = new ProblemDetails();

        problemDetails.Instance = httpContext.Request.Path;

        if (exception is BaseException e)
        {
            httpContext.Response.StatusCode = (int)e.StatusCode;
            problemDetails.Title = e.Message;
        }

        else if (exception is GenreNotExistsException e1)
        {
            httpContext.Response.StatusCode = (int)e1.StatusCode;
            problemDetails.Title = e1.Message;
        }
        else if (exception is GenreNameExistsException e2)
        {
            httpContext.Response.StatusCode = (int)e2.StatusCode;
            problemDetails.Title = e2.Message;
        }
        else if (exception is PlatformNotExistsException e3)
        {
            httpContext.Response.StatusCode = (int)e3.StatusCode;
            problemDetails.Title = e3.Message;
        }
        else if (exception is GameNotExistsException e4)
        {
            httpContext.Response.StatusCode = (int)e4.StatusCode;
            problemDetails.Title = e4.Message;
        }
        else
        {
            problemDetails.Title = exception.Message;
        }
        problemDetails.Status = httpContext.Response.StatusCode;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken).ConfigureAwait(false);

        return true;
    }
}