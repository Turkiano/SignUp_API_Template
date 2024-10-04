using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.Controllers;

public class OrderController : BaseController
{

    private IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<OrderReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        
        return Ok(_orderService!.FindAll(limit, offset));
    }

    [HttpGet("{orderId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<OrderReadDto?> FindOne(Guid orderId)
    {
        OrderReadDto order = _orderService.FindOne(orderId);
        if (order is null) return NotFound();
        return Ok(order);
    }


    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<OrderReadDto> CreateOne([FromBody] OrderCreateDto order)
    {
        if (order is not null)
        {
            var newOrder = _orderService!.CreateOne(order); //sendin request to service
            Console.WriteLine($"testing new order = {newOrder.UserId}");
            
            return CreatedAtAction(nameof(CreateOne), newOrder); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }



    [HttpPatch(":orderId")] // (POST, PUT, or PATCH) use fromBody
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<OrderReadDto> UpdateOne(Guid orderId, [FromBody] OrderUpdateDto updatedOrder)
    {
        OrderReadDto order = _orderService.UpdateOne(orderId, updatedOrder);
        if (order is null) return NotFound();

        return Accepted(order);
    }


}