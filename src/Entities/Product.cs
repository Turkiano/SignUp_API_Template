using System.ComponentModel.DataAnnotations;
namespace Coffee_Shop_App.src.Entities;

public class Product
{
    public Product(string? product_Id, string? product_Name, string? quantity, string? price)
    {
        Product_Id = product_Id;
        Product_Name = product_Name;
        Quantity = quantity;
        Price = price;
    }

    public string? Product_Id { get; set; }

    // public DateTime CreatedAt {get; set;} = DateTime.Now;
    public string? Product_Name { get; set; }

    // public Category? Category { get; set; }

    // public Guid CategoryId { get; set; }
    // public string? Image { get; set; }
    public string? Quantity { get; set; }

    // public string? Description { get; set; }

    public string? Price { get; set; }

}

