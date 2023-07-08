using ApiLogin.Api.Data;
using ApiLogin.Api.Factories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Injeccion del Factory.
builder.Services.AddSingleton(UserRespositoryFactories.Create());

// Configuracion de Entity Framework.
var configuration = builder.Configuration;
var GetConnectionString = configuration.GetConnectionString("connStringDev");
builder.Services.AddDbContext<UserDBContext>(options =>
{
    options.UseSqlServer(GetConnectionString);
});

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
