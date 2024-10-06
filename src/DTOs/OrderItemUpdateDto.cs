namespace Coffee_Shop_App.src.DTOs;


public class OrderItemUpdateDto
{
    public int? Quantity { get; set; }
    // Usually, UnitPrice is not updatable in order items, but you can include it if necessary
    public double? UnitPrice { get; set; }
}
