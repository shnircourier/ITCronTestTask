using System.Net;

namespace ITCronTestTask.Domain.Exceptions;

public class BlException : Exception
{
    public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.InternalServerError;

    public BlException(string message) : base(message) { }

    public BlException(string message, HttpStatusCode statusCode) : base(message)
    {
        StatusCode = statusCode;
    }
}