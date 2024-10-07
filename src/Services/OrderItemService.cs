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
        var foundOrderItem = _OrderItemRepository!.findOne(orderItem.OrderId, orderItem.ProductId); //to avoid duplicated emails

        if (foundOrderItem is not null)
        {
            return null;
        }

        OrderItem mapperOrderItem = _mapper.Map<OrderItem>(orderItem);
        OrderItem newOrderItem = _OrderItemRepository.CreateOne(mapperOrderItem);
        OrderItemReadDto orderItemRead = _mapper.Map<OrderItemReadDto>(newOrderItem);
        return orderItemRead;
    }

    public IEnumerable<OrderItemReadDto> FindAll(int limit, int offset)
    {
        IEnumerable<OrderItem> orderItem = _OrderItemRepository.FindAll(limit, offset); //to talk to the Repo
        IEnumerable<OrderItemReadDto> orderItemRead = orderItem.Select(_mapper.Map<OrderItemReadDto>);

        return orderItemRead;
    }

    public OrderItemReadDto? findOne(Guid orderItemId)
    {
        OrderItem orderItem = _OrderItemRepository.findById(orderItemId);
        // Return null if the item was not found
        if (orderItem == null)
        {
            return null;
        }
        OrderItemReadDto orderItemRead = _mapper.Map<OrderItemReadDto>(orderItem);

        return orderItemRead;
    }

    public OrderItemReadDto? UpdateOne(Guid orderItemId, OrderItemUpdateDto orderItemUpdateDto)
    {
        var existingOrderItem = _OrderItemRepository.findById(orderItemId);
        if (existingOrderItem == null)
        {
            return null; // Return null if the item does not exist
        }

        _mapper.Map(orderItemUpdateDto, existingOrderItem); // Map updates to the existing entity
        OrderItem updatedOrderItem = _OrderItemRepository.UpdateOne(existingOrderItem);

        return _mapper.Map<OrderItemReadDto>(updatedOrderItem);
    }

     public async Task<bool> DeleteOneAsync(Guid orderItemId)
    {
        // Add any additional validation or business rules here if necessary
        var isDeleted = await _OrderItemRepository.DeleteOneAsync(orderItemId);
        if (!isDeleted)
        {
            throw new KeyNotFoundException($"OrderItem with ID {orderItemId} not found.");
        }

        return isDeleted;
    }

}