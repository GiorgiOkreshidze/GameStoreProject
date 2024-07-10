using System.Net;

namespace Gamestore.Middlewares.Exception;

public class BaseException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : System.Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}