


namespace Coffee_Shop_App.src.Entities;

public class OrderItem {
   

    public Guid? Id { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? ProductId { get; set; }
    public short Quantity { get; set; }
    public double UnitPrice { get; set; }

    public Order? Order { get; set; }
    public Product? Product { get; set; }

    
   
}