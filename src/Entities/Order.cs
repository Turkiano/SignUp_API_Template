

namespace Coffee_Shop_App.src.Entities;


public class Order {
    public string? Id { get; set; }
    public string? UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public string? Status { get; set; }

    public User? User { get; set; }
    public ICollection<OrderItem>? OrderItems { get; set; }

    // public IEnumerable<Order_Item> OrderItem {get; set;}

   
}