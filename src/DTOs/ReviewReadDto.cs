namespace Coffee_Shop_App.src.DTOs;

public class ReviewReadDto
{

    public Guid reviewId { get; set; }
    public Guid userId { get; set; }
    public Guid productId { get; set; }

    public string? rating { get; set; }
    public string? comment { get; set; }
    public DateTime reviewDate { get; set; }
}