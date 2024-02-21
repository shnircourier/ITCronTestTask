using ITCronTestTask.Domain.Abstractions;
using ITCronTestTask.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITCronTestTask.Controllers;

[ApiController]
[Route("[controller]")]
public class IpInfoHistoriesController : ControllerBase
{
    private readonly IIpInfoHistoryService _historyService;

    public IpInfoHistoriesController(IIpInfoHistoryService historyService)
    {
        _historyService = historyService;
    }

    [HttpGet]
    public async Task<List<IpInfo>> Get()
    {
        return await _historyService.GetAll();
    }
}