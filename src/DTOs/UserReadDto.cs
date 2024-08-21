using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.DTOs;

public class UserReadDto
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


}