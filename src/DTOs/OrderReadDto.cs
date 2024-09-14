namespace Coffee_Shop_App.src.DTOs;

public class OrderReadDto{

     public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
}