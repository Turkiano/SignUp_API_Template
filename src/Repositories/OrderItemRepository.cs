using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Repositories;

public class OrderItemRepository : IOrderItemRepository
{

    private List<OrderItem> _orderItems; //to get orders as a list

    public OrderItemRepository()
    {
        _orderItems = new DatabaseContext().orderItems;
    }

    public List<OrderItem> FindAll()
    {
        return _orderItems;
    }

    public OrderItem? findOne(string orderItemId)
    {
        OrderItem? orderItem = _orderItems?.FirstOrDefault(o => o.Order_Id == orderItemId); //lambda expression to compare Ids
        return orderItem; //to get the desired user
    }
}