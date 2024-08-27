using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
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
    public IEnumerable<Order> findAll()
    {
        return _orderService.FindAll();
    }

    [HttpGet("{orderId}")]
    public Order? findOne(string orderId)
    {

        return _orderService.findOne(orderId);
    }


    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<Order> CreateOne([FromBody] Order order)
    {
        if (order is not null)
        {
            var newOrder = _orderService!.CreateOne(order); //sendin request to service
            return CreatedAtAction(nameof(CreateOne), newOrder); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }


    



}