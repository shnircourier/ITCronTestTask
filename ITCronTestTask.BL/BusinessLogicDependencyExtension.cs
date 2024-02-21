using ITCronTestTask.BL.Services;
using ITCronTestTask.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ITCronTestTask.BL;

public static class BusinessLogicDependencyExtension
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IHttpService, HttpService>();
        serviceCollection.AddScoped<IIpInfoHistoryService, IpInfoHistoryService>();
        serviceCollection.AddScoped<IIpInfoService, IpInfoService>();

        return serviceCollection;
    }
}