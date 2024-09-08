namespace Coffee_Shop_App.src.DTOs;

public class OrderItemCreateDto
{

    public Guid? OrderId { get; set; }
    public Guid? ProductId { get; set; }
    public short Quantity { get; set; }
}