using AutoMapper;

using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Controllers;

public class OrderService : IOrderService
{
    private IOrderRepository? _orderRepository;

    private IMapper _mapper; //to map DTO file with User entities



    public OrderService(IOrderRepository? orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
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

    public OrderReadDto? FindOne(string orderId)
    {
        Order? order = _orderRepository!.findOne(orderId);
        OrderReadDto orderRead = _mapper.Map<OrderReadDto>(order);


        return orderRead;
    }
}