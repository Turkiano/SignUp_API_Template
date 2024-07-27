
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;


public class UserController : BaseController //the inheritance to get the routing
{

    private IUserService? _userService;

    public UserController(IUserService userService){
        _userService = userService;
    }

   


    [HttpGet] //import the ASP.NetCore package
    public List<User>? findAll()
    {
        return _userService.FindAll(); //access to users's data
    }


    // [HttpPost] //POST, PUT, or PATCH use fromBody
    // public List<User> CreateOne([FromBody] User user)
    // {
    //     Console.WriteLine($"This is the new data {user.FirstName}"); //this is to test the method
    //     _users?.Add(user); //to save data in temporary
    //     return _users; //to send data to User list
    // }


    // [HttpGet("{userId}")] 
    // public User? findOne(string userId)
    // {
    //     User? user = _users?.FirstOrDefault( user => user.Id == userId);
        
    //     return user; 
    // }

}


