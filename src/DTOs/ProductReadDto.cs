


namespace Coffee_Shop_App.src.DTOs;

public class ProductReadDto
{
    public string? Product_Id { get; set; }

    public string? Category { get; set; }


    // [ForeignKey("Category")]
    // public string CategoryId { get; set; }
    public string? Product_Name { get; set; }

    public string? Image { get; set; }
    public string? Quantity { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }
}
