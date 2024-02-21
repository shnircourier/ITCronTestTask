using ITCronTestTask.Domain.Abstractions;
using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.BL.Services;

public class IpInfoHistoryService : IIpInfoHistoryService
{
    private readonly IIpHistoriesRepository _ipHistoriesRepository;

    public IpInfoHistoryService(IIpHistoriesRepository ipHistoriesRepository)
    {
        _ipHistoriesRepository = ipHistoriesRepository;
    }

    public async Task<List<IpInfo>> GetAll()
    {
        return await _ipHistoriesRepository.Get();
    }

    public async Task<IpInfo?> GetById(string ip)
    {
        return await _ipHistoriesRepository.Get(ip);
    }

    public async Task Create(IpInfo ipInfo)
    {
        await _ipHistoriesRepository.Create(ipInfo);
    }
}