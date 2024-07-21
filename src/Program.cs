using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Services;
using Coffee_Shop_App.src.Repositories;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src;

var builder = WebApplication.CreateBuilder(args);

//Should be added (1)
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Should be added (2)
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();


