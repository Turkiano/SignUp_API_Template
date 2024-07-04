using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Controller;


public class UserController : BaseController
{

    private IUserService _userService; //private field using interface

    public UserController(IUserService userService)
    {

        _userService = userService;
    }

    public List<User> FindAll()
    {

        return _userService.FindAll();
    }


    public List<User> CreateOne()
    {

        return _userService.CreateOne();


    }
}