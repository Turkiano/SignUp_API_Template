using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Controllers;

public class OrderRepository : IOrderRepository
{


    private List<Order> _orders; //this to get orders info as a list//this to get users info as a list

    public OrderRepository() //constructor to get orders data from DB
    {
        _orders = new DatabaseContext().orders; // new obj database to get users' list
    }

    public Order CreateOne(Order order)
    {
        _orders?.Add(order);
        return order;
    }

    public List<Order> FindAll()
    {
        return _orders;
    }

    public Order? findOne(string orderId)
    {
        Order? order = _orders?.FirstOrDefault(order => order.Order_Id == orderId); //lambda expression to compare Ids

        return order;
    }
}