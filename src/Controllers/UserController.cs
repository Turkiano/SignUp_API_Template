
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;





public class UserController : BaseController //the inheritance to get the routing
{

    private List<User>? _users; //this to get users info as a list

    public UserController() //constructor to get users data from DB
    {

        _users = new DatabaseContext().users; // new obj database to get users' list

    }


    [HttpGet] //import the ASP.NetCore package
    public List<User>? findAll()
    {
        return _users; //access to users's data
    }

}


