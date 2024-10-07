using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.Controllers;

public class OrderItemController : BaseController
{

    private IOrderItemService _orderItemService;

    public OrderItemController(IOrderItemService orderItemService)
    {
        _orderItemService = orderItemService;
    }




    [HttpGet] //import the ASP.NetCore package
    // [Authorize(Roles = "Admin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<OrderItemReadDto>>? findAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        return Ok(_orderItemService!.FindAll(limit, offset)); //access to users's data
    }


    [HttpGet("{orderItemId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<OrderItemReadDto?> findOne(Guid orderItemId)
    {
        var orderItem = _orderItemService.findOne(orderItemId);
        if (orderItem is null) return NotFound();
        return Ok(orderItem);
    }



    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<OrderItemReadDto> CreateOne([FromBody] OrderItemCreateDto orderItem)
    {
        if (orderItem is not null)
        {
            var newOrderItem = _orderItemService!.CreateOne(orderItem); //sendin request to service
            return CreatedAtAction(nameof(CreateOne), newOrderItem); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }


}