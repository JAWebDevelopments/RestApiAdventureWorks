using AdventureWorks.Domain.Repository;
using AdventureWorks.Domain.Services;
using AdventureWorks.Infrastructure;
using AdventureWorks.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<AdventureWorks2019Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZiggyRafiqConnection")));

// Register domain services
builder.Services.AddScoped<EmployeeService>();

// Register repositories
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
