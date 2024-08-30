

namespace Coffee_Shop_App.src.Entities;

public class Product
{
    public Product(Guid id, string name, Guid categoryId, short quantity, string description, double price, DateTime createdAt, string category, string image)
    {
        Id = id;
        Name = name;
        CategoryId = categoryId;
        Quantity = quantity;
        Description = description;
        Price = price;
        CreatedAt = createdAt;
        this.Category = category;
        Image = image;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
    public short Quantity { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Category { get; set; }
    public string Image { get; set; }

    public Category Category { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    // public ICollection<Review> Reviews { get; set; }

}

