


namespace Coffee_Shop_App.src.Entities;

public class OrderItem
{
    public Guid Id { get; set; } // Primary Key
    public Guid OrderId { get; set; } // Foreign Key to Order entity
    public Order? Order { get; set; } // Navigation property to Order

    public Guid ProductId { get; set; } // Foreign Key to Product entity
    public Product? Product { get; set; } // Navigation property to Product

    public int Quantity { get; set; } // Quantity of the product in the order
    public double UnitPrice { get; set; } // Price of the product at the time of ordering

    // Optional convenience property to calculate total price for this item
    public double TotalPrice => Quantity * UnitPrice;
}
