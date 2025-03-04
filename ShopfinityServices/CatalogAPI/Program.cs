using CatalogAPI.Products.GetProductByCategoryName;
using CoreLibrary.HandlingExceptions;
using FluentValidation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddValidatorsFromAssemblyContaining<GetProductsByCategoryNameQueryValidator>();


builder.Services.AddMarten(config =>
    config.Connection(builder.Configuration.GetConnectionString("Postgres")!));

builder.Services.AddCarter();

builder.Services.AddExceptionHandler<CustomExceptionHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseExceptionHandler(options => { });

app.MapCarter();
app.Run();

