


namespace Coffee_Shop_App.src.Entities;

public class OrderItem {
   

    public string? Id { get; set; }
    public string? OrderId { get; set; }
    public string? ProductId { get; set; }
    public short Quantity { get; set; }
    public double UnitPrice { get; set; }

    public Order? Order { get; set; }
    public Product? Product { get; set; }

    
   
}