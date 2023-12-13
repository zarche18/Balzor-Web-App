using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using ProductWeb.API.Application.Interfaces;
using ProductWeb.API.Application.Services;
using ProductWeb.API.Core.Repositories;
using ProductWeb.API.Infrastructure.Data;
using ProductWeb.API.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductWebDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OnlineShop"), b => b.MigrationsAssembly("ProductWeb.API")));

builder.Services.AddScoped<IProductRepository, ProductsRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>policy.WithOrigins("https://localhost:7157", "http://localhost:7157")
.AllowAnyOrigin()
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType)); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
