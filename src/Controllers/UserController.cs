
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;



[ApiController]
[Route("api/v1/[controller]")]

public class UserController : BaseController
{
    [HttpGet]
    public string Hello()
    {
        return "Hello world!";
    }

    [HttpPost]
    public string Greeting()
    {
        return "good morning";
    }
}