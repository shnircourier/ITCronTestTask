using ITCronTestTask.Domain.Abstractions;
using ITCronTestTask.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITCronTestTask.Controllers;

[ApiController]
[Route("[controller]")]
public class IpInfoController : ControllerBase
{
    private readonly IIpInfoService _ipInfoService;

    public IpInfoController(IIpInfoService ipInfoService)
    {
        _ipInfoService = ipInfoService;
    }

    [HttpGet("{ip}")]
    public async Task<IpInfo?> Get([FromRoute] string ip)
    {
        return await _ipInfoService.GetIpInfo(ip);
    }
}