namespace Coffee_Shop_App.src.DTOs;


public class OrderItemReadDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public string? ProductName { get; set; } // Optional: to include product details
    public int Quantity { get; set; }
    public double UnitPrice { get; set; } // Price of the product when ordered
    public double TotalPrice => Quantity * UnitPrice; // Optional: to show the total for this item
}
