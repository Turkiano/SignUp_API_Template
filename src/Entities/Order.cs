

using Coffee_Shop_App.src.Enum;

namespace Coffee_Shop_App.src.Entities;


public class Order
{
    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public Status? Status { get; set; }

    public User? User { get; set; }
    public ICollection<OrderItem>? OrderItems { get; set; }



}