using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;





public class UserController : BaseController
{
    private IUserService _userService; //private field using interface


    public UserController(IUserService userService)//constructor
    {

        _userService = userService;
    }

    public List<User> FindAll()
    {

        return _userService.FindAll();
    }


    public List<User> CreateOne([FromBody] User user)
    {

        return _userService.CreateOne(user);


    }
}