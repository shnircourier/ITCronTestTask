using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ITCronTestTask.Data;

public static class DatabaseAutoMigrationExtension
{
    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<IpInfoDbContext>();
        context.Database.Migrate();

        return app;
    }
}