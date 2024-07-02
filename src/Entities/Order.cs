

namespace Coffee_Shop_App.src.Entities;


public class Order {
    public Guid Order_Id {get; set;}
    public Guid User_Id {get; set;}
    public string Customer_Name {get; set;}
    public string Status {get; set;}

    public int Daily_Count {get; set;}

    // public IEnumerable<Order_Item> OrderItem {get; set;}

}