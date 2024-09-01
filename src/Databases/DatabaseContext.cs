using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Coffee_Shop_App.src.Databases;
public class DatabaseContext : DbContext //inheriting from the EF Core package
{
    private IConfiguration _config;

    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }


    // to store Entities' data as a list
    public DbSet<User>? Users { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Order>? Orders { get; set; }
    public DbSet<OrderItem>? OrderItems { get; set; }


    // The Connection String (On Configuration)
     
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host=localhost; Username=postgres; Database=coffeeshop; Password=QQAAZZ12341234");

    // configuring DB
   
    // var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db_Host"]};Username={_config["Db_Username"]};Database={_config["Db_Database"]};Password={_config["Db_Password"]}");
    // dataSourceBuilder.MapEnum<Role>();
   
}

