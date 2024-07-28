

using Coffee_Shop_App;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_Appe.src.Abstractions;
using Npgsql.Replication;

var builder = WebApplication.CreateBuilder(args);

//Should be added (1)
builder.Services.AddControllers();

//Should be added (3) to lowercase the Route
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>(); //built-in DI Container for UserRepository
builder.Services.AddScoped<IUserService, UserService>(); //built-in DI Container for UserService


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


