using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Controllers;

public class OrderRepository : IOrderRepository
{

    private DatabaseContext _dbContext;
    // private DbSet<Order> _orders; //this to get orders info as a list//this to get users info as a list

    public OrderRepository(DatabaseContext dbContext) //constructor to get orders data from DB
    {
        _dbContext = dbContext; // new obj database to get Orders' list
    }

    public Order CreateOne(Order order)
    {
        _dbContext?.Add(order);
        _dbContext.SaveChanges();
        return order;
    }

    public IEnumerable<Order> FindAll(int limit, int offset)
    {
        if (limit == 0 && offset == 0)
        { // 1.if pagination has empty values
            return _dbContext.Orders!; // 2.show all produts
        }
        // 3.else show the values of pagination
        return _dbContext.Orders.Skip(offset).Take(limit);
    }

    public Order? findOne(Guid orderId)
    {
        // Order? order = _orders?.FirstOrDefault(order => order.Id == orderId); //lambda expression to compare Ids
        Order order = _dbContext.Orders.Find(orderId);

        return order;

    }


    public Order UpdateOne(Order order)
    {
        _dbContext.Orders.Update(order);
        _dbContext.SaveChanges();
        return order;
    }
}