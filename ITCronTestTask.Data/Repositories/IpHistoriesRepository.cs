using AutoMapper;
using ITCronTestTask.Data.Entities;
using ITCronTestTask.Domain.Abstractions;
using ITCronTestTask.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ITCronTestTask.Data.Repositories;

public class IpHistoriesRepository : IIpHistoriesRepository
{
    private readonly IpInfoDbContext _context;
    private readonly IMapper _mapper;

    public IpHistoriesRepository(IpInfoDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<List<IpInfo>> Get()
    {
        var entities = await _context.IpInfoHistories
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<List<IpInfo>>(entities);
    }

    public async Task<IpInfo?> Get(string ip)
    {
        var entity = await _context.IpInfoHistories.FirstOrDefaultAsync(x => x.Ip == ip);

        return _mapper.Map<IpInfo?>(entity);
    }

    public async Task Create(IpInfo ipInfo)
    {
        var entity = _mapper.Map<IpInfoHistory>(ipInfo);

        await _context.IpInfoHistories.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
}