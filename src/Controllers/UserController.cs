
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;



[ApiController]
[Route("api/v1/[controller]")]

public class UserController 
{


    [HttpGet]
    public string Hello()
    {
        UserService helloService = new ();
        return helloService.SayHi();
    }

    
}