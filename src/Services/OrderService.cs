using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Controllers;

public class OrderService : IOrderService
{
    private IOrderRepository? _orderRepository;

    public OrderService(IOrderRepository? orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Order CreateOne(Order order)
    {
        Order? foundOrder = _orderRepository!.findOne(order.Id); //to avoid duplicated orders
        
        if (foundOrder is not null)
        {
            return null;
        }

        return _orderRepository.CreateOne(order);
    }

    public IEnumerable<Order> FindAll()
    {
        return _orderRepository!.FindAll();
    }

    public Order? findOne(string orderId)
    {
        return _orderRepository!.findOne(orderId);
    }
}