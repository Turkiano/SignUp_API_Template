


namespace Coffee_Shop_App.src.Entities;

public class Review
{


    public Guid reviewId { get; set; }
    public Guid userId { get; set; }
    public Guid productId { get; set; }

    public string? rating { get; set; }
    public string? comment { get; set; }
    public DateTime reviewDate { get; set; }


    public User? user { get; set; }
    public Product? product { get; set; }




}
