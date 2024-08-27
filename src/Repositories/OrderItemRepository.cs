using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Repositories;

public class OrderItemRepository : IOrderItemRepository
{

    private DbSet<OrderItem> _orderItems; //to get orders as a list

    public OrderItemRepository(DatabaseContext databaseContext)
    {
        _orderItems = databaseContext.OrderItems;
    }

    public OrderItem CreateOne(OrderItem orderItem)
    {
        _orderItems.Add(orderItem);
        return orderItem;
    }

    public IEnumerable<OrderItem> FindAll()
    {
        return _orderItems;
    }

    public OrderItem? findOne(string orderItemId)
    {
        OrderItem? orderItem = _orderItems?.FirstOrDefault(o => o.Order_Id == orderItemId); //lambda expression to compare Ids
        return orderItem; //to get the desired user
    }
}