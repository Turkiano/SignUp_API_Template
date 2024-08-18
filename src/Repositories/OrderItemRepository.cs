using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Repositories;

public class OrderItemRepository {

    private List<Order_item>_orderItems; //to get orders as a list

    public OrderItemRepository()
    {
        _orderItems = new DatabaseContext().orderItems;
    }
}