namespace Coffee_Shop_App.src.DTOs;

public class ReviewReadDto
{

    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public string? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? ReviewDate { get; set; } = DateTime.Now;
}