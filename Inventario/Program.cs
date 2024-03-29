using Inventario.Application.Services;
using Inventario.Domain.Interfaces;
using Inventario.Infrastructure;
using Inventario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Database
builder.Services.AddDbContext<ContextDB>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Default"))
);

// Configure AutoMapping
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Configure Interface Repository
builder.Services.AddScoped<IMaquinaRepository, MaquinaRepository>();
builder.Services.AddScoped<MaquinaService>();

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
