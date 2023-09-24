using AutoMapper;
using IkeaClone.Repository.Repositories;
using IkeaClone.Services.Dtos;
using IkeaClone.Services.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IReadOrderService, ReadOrderService>();
builder.Services.AddScoped<IWriteOrderService, WriteOrderService>();
builder.Services.AddScoped<IReadOrderItemsService, ReadOrderItemsService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IFurnitureRepository, FurnitureRepository>();
builder.Services.AddScoped<ITextileRepository, TextileRepository>();
builder.Services.AddScoped<IHotDogRepository, HotDogRepository>();


//Configure Automapper
var mapperConfig = new MapperConfiguration(mc => mc.AddMaps(Assembly.GetAssembly(typeof(OrderItemDto))));

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

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
