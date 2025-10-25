using BugStore.Domain.Commands.Customer.Create;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddMediatR(typeof(Program).GetTypeInfo().Assembly, typeof(CreateRequest).GetTypeInfo().Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.MapGet("/", () => "Hello World!");

//app.MapGet("/v1/customers", () => "Hello World!");
//app.MapGet("/v1/customers/{id}", () => "Hello World!");
//app.MapPost("/v1/customers", () => "Hello World!");
//app.MapPut("/v1/customers/{id}", () => "Hello World!");
//app.MapDelete("/v1/customers/{id}", () => "Hello World!");

//app.MapGet("/v1/products", () => "Hello World!");
//app.MapGet("/v1/products/{id}", () => "Hello World!");
//app.MapPost("/v1/products", () => "Hello World!");
//app.MapPut("/v1/products/{id}", () => "Hello World!");
//app.MapDelete("/v1/products/{id}", () => "Hello World!");

//app.MapGet("/v1/orders/{id}", () => "Hello World!");
//app.MapPost("/v1/orders", () => "Hello World!");

app.Run();
