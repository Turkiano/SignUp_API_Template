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
    public IEnumerable<OrderItemReadDto>? findAll()
    {
        return _orderItemService!.FindAll(); //access to users's data
    }


    [HttpGet("{orderItemId}")]
    public OrderItemReadDto? findOne(string orderItemId)
    {

        return _orderItemService!.findOne(orderItemId);
    }



    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<OrderItem> CreateOne([FromBody] OrderItem orderItem)
    {
        if (orderItem is not null)
        {
            var newOrderItem = _orderItemService!.CreateOne(orderItem); //sendin request to service
            return CreatedAtAction(nameof(CreateOne), newOrderItem); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }


}