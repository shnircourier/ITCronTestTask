using ITCronTestTask.Data.Repositories;
using ITCronTestTask.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ITCronTestTask.Data;

public static class DataDependencyExtension
{
    public static IServiceCollection AddDataLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IIpHistoriesRepository, IpHistoriesRepository>();

        return serviceCollection;
    }
}