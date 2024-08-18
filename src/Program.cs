
using Coffee_Shop_App.Controllers;
using Coffee_Shop_App.Repositories;
using Coffee_Shop_App.Services;
using Coffee_Shop_App.src.Abstractions;


var builder = WebApplication.CreateBuilder(args);

//Should be added (1)
builder.Services.AddControllers();

//Should be added (3) to lowercase the Route
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Dependency Injection Containers for Abstraction classes
builder.Services.AddScoped<IUserRepository, UserRepository>(); //built-in DI Container for UserRepository
builder.Services.AddScoped<IUserService, UserService>(); //built-in DI Container for UserService
builder.Services.AddScoped<IProductRepository, ProductRepository>(); //built-in DI Container for ProductRepository
builder.Services.AddScoped<IProductService, ProductService>(); //built-in DI Container for ProductService
builder.Services.AddScoped<ICategoryService, CategoryService>(); //built-in DI Container for CategoryService
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>(); //built-in DI Container for CategoryRepository
builder.Services.AddScoped<IOrderService, OrderService>(); //built-in DI Container for OrderService
builder.Services.AddScoped<IOrderRepository, OrderRepository>(); //built-in DI Container for OrderRepository


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


