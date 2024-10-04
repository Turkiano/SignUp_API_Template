using System.ComponentModel.DataAnnotations;
using Coffee_Shop_App.src.Enum;

namespace Coffee_Shop_App.src.DTOs;

public class OrderUpdateDto
{

[EnumDataType(typeof(Status), ErrorMessage = "Invalid status value.")]
    public Status Status { get; set; }

}