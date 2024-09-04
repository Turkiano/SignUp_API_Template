using System.ComponentModel.DataAnnotations;
namespace Coffee_Shop_App.src.Entities;


public class User
{
   

    [Required]
    public string? Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Phone { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Password { get; set; }

    public string? Salt { get; set; }
    public string? Role { get; set; }

    public ICollection<Order>? Orders { get; set; }
    public ICollection<Review> Reviews { get; set; }









}