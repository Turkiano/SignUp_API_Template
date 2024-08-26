using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_App.src.DTOs;

public class ProductCreateDto{

    

    [ForeignKey("Category")]
    // public string CategoryId { get; set; }
    // public DateTime CreatedAt {get; set;} = DateTime.Now;
    public string? Product_Name { get; set; }

    public string Category { get; set; }

    public string? Image { get; set; }
    public string? Quantity { get; set; }

    public string? Description { get; set; }

    public string? Price { get; set; }
}