

namespace Coffee_Shop_App.src.Entities;

public class Product
{


    public Guid? Id { get; set; }
    public Guid? Name { get; set; }
    public Guid? CategoryId { get; set; }
    public short Quantity { get; set; }
    public string? Description { get; set; }
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }
    // public string Category { get; set; }
    public string? Image { get; set; }

    public Category? Category { get; set; }
    public ICollection<OrderItem>? OrderItems { get; set; }
    public ICollection<Review>? Reviews { get; set; }

}

