

namespace Coffee_Shop_App.src.Entities;


public class Order {
    public Order(Guid id, Guid userId, DateTime orderDate, string status, User user, ICollection<OrderItem> orderItems)
    {
        Id = id;
        UserId = userId;
        OrderDate = orderDate;
        Status = status;
        User = user;
        OrderItems = orderItems;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public string Status { get; set; }

    public User User { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }

    // public IEnumerable<Order_Item> OrderItem {get; set;}

   
}