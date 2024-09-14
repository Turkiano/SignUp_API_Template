namespace Coffee_Shop_App.src.DTOs;


public class OrderItemReadDto
{

    public Guid? Id { get; set; }
    public Guid? OrderId { get; set; }
    public Guid? ProductId { get; set; }
    public short Quantity { get; set; }
    public double UnitPrice { get; set; }
}