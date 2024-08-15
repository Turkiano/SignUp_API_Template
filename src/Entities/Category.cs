namespace Coffee_Shop_App.src.Entities;

public class Category
{

    public string CategoryId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;




    public Category(string categoryId, string name, DateTime createdAt) //the constructor
    {
        CategoryId = categoryId;
        Name = name;
        CreatedAt = createdAt;

    }
}