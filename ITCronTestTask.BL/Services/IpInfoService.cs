using System.Net;
using System.Text.RegularExpressions;
using ITCronTestTask.Domain.Abstractions;
using ITCronTestTask.Domain.Exceptions;
using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.BL.Services;

public class IpInfoService : IIpInfoService
{
    private const string BaseUrl = "https://ipinfo.io/{0}/geo";
    private const string IpPattern = @"^1(\.\d{1,3}){3}$|^(?!255(\.\d{1,3}){3}$)\d{1,3}(\.\d{1,3}){3}$";
    
    private readonly IHttpService _httpService;
    private readonly IIpInfoHistoryService _ipInfoHistoryService;

    public IpInfoService(IHttpService httpService, IIpInfoHistoryService ipInfoHistoryService)
    {
        _httpService = httpService;
        _ipInfoHistoryService = ipInfoHistoryService;
    }

    public async Task<IpInfo?> GetIpInfo(string ip)
    {
        if (!Regex.IsMatch(ip, IpPattern)) throw new BlException("Недопустимый ip адрес", HttpStatusCode.BadRequest);
        
        var ipInfo = await _httpService.SendRequest<IpInfo>(string.Format(BaseUrl, ip), HttpMethod.Get);

        if (ipInfo is not null && await _ipInfoHistoryService.GetById(ipInfo.Ip) is null) 
            await _ipInfoHistoryService.Create(ipInfo);

        return ipInfo;
    }
}