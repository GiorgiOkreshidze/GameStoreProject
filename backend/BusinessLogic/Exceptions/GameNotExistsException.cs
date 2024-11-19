using System.Net;

namespace BusinessLogic.Exceptions;

public class GameNotExistsException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}