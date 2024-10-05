using System.ComponentModel.DataAnnotations;
using Coffee_Shop_App.src.Enum;
using Microsoft.EntityFrameworkCore;
namespace Coffee_Shop_App.src.Entities;

//unique property index 
// to make emails unique in database
[Index(nameof(Email), IsUnique = true)]
public class User
{

    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Required]
    [Phone]
    public string? Phone { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    public string? Salt { get; set; }
    [Required]
    public Role Role { get; set; } = Role.Customer; //enum

    public ICollection<Order>? Orders { get; set; }
    public ICollection<Review>? Reviews { get; set; }

}