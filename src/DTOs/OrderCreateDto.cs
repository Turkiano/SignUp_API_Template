using System.ComponentModel.DataAnnotations;
using Coffee_Shop_App.src.Enum;

namespace Coffee_Shop_App.src.DTOs;

public class OrderCreateDto
{

    public Guid? Id { get; set; }
    public Guid? UserId { get; set; }


    [EnumDataType(typeof(Status), ErrorMessage = "Invalid status value.")]
    public Status Status { get; set; }

}
