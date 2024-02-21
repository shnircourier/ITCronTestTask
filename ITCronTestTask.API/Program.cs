using ITCronTestTask.BL;
using ITCronTestTask.Data;
using ITCronTestTask.Middlewares;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<IpInfoDbContext>(opts =>
{
    opts.UseNpgsql(builder.Configuration.GetConnectionString(nameof(IpInfoDbContext)));
});

builder.Services.AddDataLayer();
builder.Services.AddBusinessLogicLayer();

builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddTransient<ExceptionHandlingMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MigrateDatabase();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();