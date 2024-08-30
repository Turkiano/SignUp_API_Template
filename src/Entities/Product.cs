

namespace Coffee_Shop_App.src.Entities;

public class Product
{
    public Product (string? product_Id, DateTime createdAt, string? product_Name, string? quantity, string? price, string category)
    {
        Product_Id = product_Id;
        CreatedAt = createdAt;
        Product_Name = product_Name;
        Quantity = quantity;
        Price = price;
        Category = category;
    }

    public Guid Product_Id { get; set; }

    public Guid CategoryId { get; set; }
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public string? Product_Name { get; set; }

    public string Category { get; set; }

    public string? Image { get; set; }
    public string? Quantity { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }

}

