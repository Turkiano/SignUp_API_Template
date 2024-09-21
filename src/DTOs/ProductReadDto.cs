


using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.DTOs;

public class ProductReadDto
{

    [Required]
    public string? Name { get; set; }
    public Guid Product_Id { get; set; }
    public string? Category { get; set; }



    // public string? Image { get; set; }
    // // public int Quantity { get; set; }

    // public string? Description { get; set; }

    // public string? Price { get; set; }
}
