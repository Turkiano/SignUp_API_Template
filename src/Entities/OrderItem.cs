


namespace Coffee_Shop_App.src.Entities;

public class OrderItem {

    public string? Order_Id {get; set;}

    public string? Product_Id {get; set;}

    public int Quantity {get; set;}

    public DateTime CreatedAt {get; set;}

    
    public OrderItem(string? order_Id, string? product_Id, int quantity, DateTime createdAt)
    {
        Order_Id = order_Id;
        Product_Id = product_Id;
        Quantity = quantity;
        CreatedAt = createdAt;
    }
}