using System.Net;

namespace BusinessLogic.Exceptions;

public class PlatformTypeExistsException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : System.Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}