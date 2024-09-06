using AutoMapper;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

public class OrderItemService : IOrderItemService
{

    private IMapper _mapper;
    private IOrderItemRepository _OrderItemRepository;//access to the Repo

    public OrderItemService(IOrderItemRepository orderItemRepository, IMapper mapper)
    {
        _OrderItemRepository = orderItemRepository;
        _mapper = mapper;
    }

    public OrderItem CreateOne(OrderItem orderItem)
    {
        OrderItem? foundOrderItem = _OrderItemRepository!.findOne(orderItem.OrderId!); //to avoid duplicated emails

        if (foundOrderItem is not null)
        {
            return null;
        }

        return _OrderItemRepository.CreateOne(orderItem);
    }

    public IEnumerable<OrderItemReadDto> FindAll()
    {
        var orderItem = _OrderItemRepository.FindAll(); //to talk to the Repo
        var orderItemRead = orderItem.Select(_mapper.Map<OrderItemReadDto>);
        
        return orderItemRead;
    }

    public OrderItem? findOne(string orderItemId)
    {
        return _OrderItemRepository.findOne(orderItemId);
    }
}