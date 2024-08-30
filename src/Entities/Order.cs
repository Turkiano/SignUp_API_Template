

namespace Coffee_Shop_App.src.Entities;


public class Order {

    public Guid Order_Id {get; set;}
    public Guid UserId {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public string Status {get; set;}

    public int Daily_Count {get; set;}

    // public IEnumerable<Order_Item> OrderItem {get; set;}

    public Order(Guid order_Id, Guid userId, DateTime createdAt, string status, int daily_Count)
    {
        Order_Id = order_Id;
        UserId = userId;
        CreatedAt = createdAt;
        Status = status;
        Daily_Count = daily_Count;
    }
}