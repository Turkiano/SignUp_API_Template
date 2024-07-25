
using Coffee_Shop_App.src.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;



[ApiController]
[Route("api/v1/[controller]")]

public class UserController 
{


    [HttpGet]
    public string SayHi() //action method
    {
        UserService helloService = new (); //obj to talk to service class
        return helloService.SayHi(); //passing request to the service
    }

    
}