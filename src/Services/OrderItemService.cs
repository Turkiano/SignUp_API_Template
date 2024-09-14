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

    public OrderItemReadDto CreateOne(OrderItemCreateDto orderItem)
    {
        OrderItem? foundOrderItem = _OrderItemRepository!.findOne((Guid)orderItem.OrderId!); //to avoid duplicated emails

        if (foundOrderItem is not null)
        {
            return null;
        }

        OrderItem mapperOrderItem = _mapper.Map<OrderItem>(orderItem);
        OrderItem newOrderItem = _OrderItemRepository.CreateOne(mapperOrderItem);
        OrderItemReadDto orderItemRead = _mapper.Map<OrderItemReadDto>(newOrderItem);
        return orderItemRead;
    }

    public IEnumerable<OrderItemReadDto> FindAll()
    {
        var orderItem = _OrderItemRepository.FindAll(); //to talk to the Repo
        var orderItemRead = orderItem.Select(_mapper.Map<OrderItemReadDto>);
        
        return orderItemRead;
    }

    public OrderItemReadDto? findOne(Guid orderItemId)
    {
        OrderItem orderItem = _OrderItemRepository.findOne(orderItemId);
        OrderItemReadDto orderItemRead = _mapper.Map<OrderItemReadDto>(orderItem);

        return orderItemRead;
    }
}