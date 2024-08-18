using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Controllers;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.Controllers;

public class OrderItemController : BaseController {

    private IOrderItemService _orderItemService;

    public OrderItemController(IOrderItemService orderItemService)
    {
        _orderItemService = orderItemService;
    }



    [HttpGet] //import the ASP.NetCore package
    public List<OrderItem>? findAll()
    {
        return _orderItemService!.FindAll(); //access to users's data
    }


     [HttpGet("{orderItemId}")]
    public OrderItem? findOne(string orderItemId)
    {

        return _orderItemService!.findOne(orderItemId);
    }


}