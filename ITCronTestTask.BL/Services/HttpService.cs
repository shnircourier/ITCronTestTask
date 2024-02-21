using System.Text.Json;
using ITCronTestTask.Domain.Abstractions;

namespace ITCronTestTask.BL.Services;

public class HttpService : IHttpService
{
    public async Task SendRequest(string url, HttpMethod method)
    {
        using var client = new HttpClient();
        var request = new HttpRequestMessage(method, url);

        await client.SendAsync(request);
    }
    
    public async Task<T?> SendRequest<T>(string url, HttpMethod method)
    {
        using var client = new HttpClient();
        var request = new HttpRequestMessage(method, url);

        var response = await client.SendAsync(request);
        
        var content = await response.Content.ReadAsStringAsync();
        
        return JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }
}