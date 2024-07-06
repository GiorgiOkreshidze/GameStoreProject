using System.Net;

namespace BusinessLogic.Exceptions;

public class GameNotExistsException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : System.Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}