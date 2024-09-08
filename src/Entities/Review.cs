

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App;

public class Review
{


    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }
    public string? Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? ReviewDate { get; set; } = DateTime.Now;


    public User? User { get; set; }
    public Product? Product { get; set; }




}
