using ITCronTestTask.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCronTestTask.Data.Configurations;

public class IpInfoEntityConfiguration : IEntityTypeConfiguration<IpInfoHistory>
{
    public void Configure(EntityTypeBuilder<IpInfoHistory> builder)
    {
        builder.HasKey(x => x.Ip);
    }
}