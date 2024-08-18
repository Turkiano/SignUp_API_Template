


namespace Coffee_Shop_App.src.Entities;

public class Order_item {

    public string? Order_Id {get; set;}

    public string? Product_Id {get; set;}

    public int Quantity {get; set;}

    public DateTime CreatedAt {get; set;}

    
    public Order_item(string? order_Id, string? product_Id, int quantity, DateTime createdAt)
    {
        Order_Id = order_Id;
        Product_Id = product_Id;
        Quantity = quantity;
        CreatedAt = createdAt;
    }
}