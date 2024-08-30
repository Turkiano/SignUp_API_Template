namespace Coffee_Shop_App.src.Entities;

public class Category
{
   
    

    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }  = DateTime.Now;

    public ICollection<Product>? Products { get; set; }




   
}