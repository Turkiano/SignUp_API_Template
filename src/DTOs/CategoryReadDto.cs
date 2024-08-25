namespace Coffee_Shop_App.src.DTOs;

public class CategoryReadDto
{


    public string? CategoryId { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

}