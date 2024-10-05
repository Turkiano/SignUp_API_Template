using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.DTOs;

public class UserCreateDto
{



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

}