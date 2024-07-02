namespace Coffee_Shop_App.src.Entities;

public class Order_items {

    public Guid Order_Id {get; set;}

    public Guid Product_Id {get; set;}

    public int Quantity {get; set;}
}