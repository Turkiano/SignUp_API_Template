


using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.DTOs;

public class ProductReadDto
{

    [Required]
    public string? Name { get; set; }
    [Required]
    public Guid ProductId { get; set; }
    [Required]
    public Guid CategoryId { get; set; }



    // public string? Image { get; set; }
    // // public int Quantity { get; set; }

    // public string? Description { get; set; }

    // public string? Price { get; set; }
}
