

using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.DTOs;

public class UserUpdateDto
{

    [Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    [Required, Phone]
    public string? Phone { get; set; }
}
