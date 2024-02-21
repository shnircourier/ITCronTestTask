using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.Domain.Abstractions;

public interface IIpHistoriesRepository
{
    Task<List<IpInfo>> Get();

    Task<IpInfo?> Get(string ip);

    Task Create(IpInfo entity);
}