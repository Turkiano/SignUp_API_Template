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

    public List<Order> FindAll()
    {
        return _orderRepository.FindAll();
    }
}