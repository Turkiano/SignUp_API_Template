using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_App.src.DTOs;

public class ProductCreateDto
{


    [Required]
    public string? Name { get; set; }
    [Required]
    public Guid productId { get; set; }
    [Required]
    public Guid CategoryId { get; set; }

    // public string Image { get; set; } ="";
    // // public int  Quantity { get; set; } 

    // public string Description { get; set; } ="";

    // public string? Price { get; set; }
}