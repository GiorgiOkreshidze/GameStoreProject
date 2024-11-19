using System.Net;

namespace BusinessLogic.Exceptions;

public class PlatformNotExistsException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}