using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

public class OrderItemService : IOrderItemService
{
    private IOrderItemRepository _OrderItemRepository;//access to the Repo

    public OrderItemService(IOrderItemRepository orderItemRepository)
    {
        _OrderItemRepository = orderItemRepository;
    }

    public List<OrderItem> FindAll()
    {
        return _OrderItemRepository.FindAll(); //to talk to the Repo
    }

    public OrderItem? findOne(string orderItemId)
    {
        return _OrderItemRepository.findOne(orderItemId);
    }
}