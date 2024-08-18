using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Controllers;

public class OrderRepository {


private List<Order> _order; //this to get orders info as a list//this to get users info as a list

    public OrderRepository() //constructor to get orders data from DB
    {
        _order = new DatabaseContext().orders; // new obj database to get users' list
    }


}