namespace Coffee_Shop_App.src.DTOs;

public class OrderReadDto{

     public string? Id { get; set; }
    public string? UserId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
}