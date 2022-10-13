using Catalog.BusinessLogicLayer;
using Catalog.DataAccessLayer;
using Catalog.DomainLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

var connectionString = builder.Configuration.GetConnectionString("CatalogDBConnectionString");
builder.Services.AddDbContext<CatalogContext>(opts => opts.UseSqlServer(connectionString));


builder.Services.AddScoped<IDataRepository<Item>, ItemRepository>();
builder.Services.AddScoped<IDataRepository<Category>, CategoryRepository>();
builder.Services.AddScoped<IBusinessLayer<Category>, CategoriesManager>();
builder.Services.AddScoped<IBusinessLayer<Item>, ItemsManager>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
