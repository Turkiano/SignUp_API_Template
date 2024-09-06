namespace Coffee_Shop_App.src.DTOs;

public class OrderItemCreateDto
{

    public string? OrderId { get; set; }
    public string? ProductId { get; set; }
    public short Quantity { get; set; }
}