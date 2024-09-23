using System.ComponentModel.DataAnnotations;

namespace Coffee_Shop_App.src.DTOs;

public class ProductUpdateDto
{

    [Required]
    public string? Name { get; set; }

    [Required]
    public Guid CategoryId { get; set; }
}