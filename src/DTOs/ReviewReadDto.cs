namespace Coffee_Shop_App.src.DTOs;

public class ReviewReadDto
{

    public string? Id { get; set; }
    public string? UserId { get; set; }
    public string? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? ReviewDate { get; set; } = DateTime.Now;
}