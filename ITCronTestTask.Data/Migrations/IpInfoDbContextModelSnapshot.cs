﻿// <auto-generated />
using ITCronTestTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ITCronTestTask.Data.Migrations
{
    [DbContext(typeof(IpInfoDbContext))]
    partial class IpInfoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ITCronTestTask.Data.Entities.IpInfoHistory", b =>
                {
                    b.Property<string>("Ip")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Hostname")
                        .HasColumnType("text");

                    b.Property<string>("Loc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Org")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Postal")
                        .HasColumnType("text");

                    b.Property<string>("Readme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Ip");

                    b.ToTable("IpInfoHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
