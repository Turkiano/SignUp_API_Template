using Npgsql;

using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;
using Coffee_Shop_App.src.Enum;


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
    public DbSet<Review> Reviews { get; set; }


    // The Connection String (On Configuration)

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       

        //Enum Type Mapping:
        var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db_Host"]}; Username={_config["Db_Username"]}; Database={_config["Db_Database"]}; Password={_config["Db_Password"]}; Include Error Detail=true");
        dataSourceBuilder.MapEnum<Role>();
        dataSourceBuilder.MapEnum<Status>();
        var dataSource = dataSourceBuilder.Build();



         optionsBuilder.UseNpgsql(dataSource);
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresEnum<Role>();
        modelBuilder.HasPostgresEnum<Status>();
    }


}

