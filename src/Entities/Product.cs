using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.Entities;

public class Product
{

    public Guid Product_Id { get; set; }

    public DateTime CreatedAt {get; set;} = DateTime.Now;
    public string Product_Name { get; set; }

    public Category Category { get; set; }

    public Guid CategoryId { get; set; }
    public string Image { get; set; }
    public int Quantity { get; set; }

    public string Description { get; set; }

    public double Price { get; set; }



}