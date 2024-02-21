using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.Domain.Abstractions;

public interface IIpInfoService
{
    Task<IpInfo?> GetIpInfo(string ip);
}