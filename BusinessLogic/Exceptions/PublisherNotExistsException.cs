using System.Net;

namespace BusinessLogic.Exceptions;

public class PublisherNotExistsException(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
    : Exception(message)
{
    public HttpStatusCode StatusCode { get; } = statusCode;
}