

namespace Coffee_Shop_App.src.Entities;


public class Order {
    public Order(string order_Id, string user_Id, string customer_Name, string status, int daily_Count)
    {
        Order_Id = order_Id;
        User_Id = user_Id;
        Customer_Name = customer_Name;
        Status = status;
        Daily_Count = daily_Count;
    }

    public string Order_Id {get; set;}
    public string User_Id {get; set;}
    public string Customer_Name {get; set;}
    public string Status {get; set;}

    public int Daily_Count {get; set;}

    // public IEnumerable<Order_Item> OrderItem {get; set;}

}