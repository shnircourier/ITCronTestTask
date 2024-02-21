using ITCronTestTask.Data.Configurations;
using ITCronTestTask.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITCronTestTask.Data;

public class IpInfoDbContext : DbContext
{
    public DbSet<IpInfoHistory> IpInfoHistories { get; set; }
    
    public IpInfoDbContext(DbContextOptions<IpInfoDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new IpInfoEntityConfiguration());
    }
}