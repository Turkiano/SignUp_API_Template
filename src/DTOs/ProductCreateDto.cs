using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee_Shop_App.src.DTOs;

public class ProductCreateDto{

    
    public Guid productId{get; set;} 
    public string Product_Name { get; set; } ="";

    public Guid CategoryId { get; set; } 

    // public string Image { get; set; } ="";
    // // public int  Quantity { get; set; } 

    // public string Description { get; set; } ="";

    // public string? Price { get; set; }
}