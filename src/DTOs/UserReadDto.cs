using System.ComponentModel.DataAnnotations;
using Coffee_Shop_App.src.Enum;

namespace Coffee_Shop_App.src.DTOs;

public class UserReadDto
{

    [Required]
    public Guid? Id { get; set; }

    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }

    [Required]
    public string? Phone { get; set; }

    [Required]
    public string? Email { get; set; }

    public string Role {get; set;}


}