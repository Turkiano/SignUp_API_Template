namespace Coffee_Shop_App.src.DTOs;


public class OrderItemReadDto
{

    public string? Id { get; set; }
    public string? OrderId { get; set; }
    public string? ProductId { get; set; }
    public short Quantity { get; set; }
    public double UnitPrice { get; set; }
}