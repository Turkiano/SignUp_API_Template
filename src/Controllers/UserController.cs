using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controller;


public class UserController : BaseController //the inheritance to get the routing
{
    private IUserService? _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpPatch]
    public User? UpdateOne([FromBody] string Email, User user)
    {
        return _userService.UpdateOne(Email, user);
    }


    [HttpGet("{Email}")] //import the ASP.NetCore package
    public List<User>? findAll()
    {
        return _userService.FindAll(); //access to users's data
    }


    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<User> CreateOne([FromBody] User user)
    {
        if (user is not null)
        {

            var newUser = _userService.CreateOne(user); //sendin request to service
            return CreatedAtAction(nameof(CreateOne), newUser); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }


    [HttpGet("{userId}")]
    public User? findOne(string userId)
    {

        return _userService.findOne(userId);
    }


    [HttpGet("userEmail")] //rename the route since we have duplicated endpoints
    public User? findOneByEmail(string userEmail)
    {

        return _userService.findOneByEmail(userEmail); //call the method in the service
    }

}


