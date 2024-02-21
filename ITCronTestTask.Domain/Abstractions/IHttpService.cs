namespace ITCronTestTask.Domain.Abstractions;

public interface IHttpService
{
    Task SendRequest(string url, HttpMethod method);
    Task<T?> SendRequest<T>(string url, HttpMethod method);
}