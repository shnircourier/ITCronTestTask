using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.Domain.Abstractions;

public interface IIpInfoHistoryService
{
    Task<List<IpInfo>> GetAll();
    Task<IpInfo?> GetById(string ip);
    Task Create(IpInfo ipInfo);
}