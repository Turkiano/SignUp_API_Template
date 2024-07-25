using Microsoft.EntityFrameworkCore;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Databases{



public class DatabasesContext : DbContext {

public DbSet<User> User {get; set;}


public DatabasesContext(DbContextOptions<DatabasesContext> options) : base(options){ }


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=myserver;Port=5432;Database=mydb;Username=myuser;Password=mypassword;");

    }

}