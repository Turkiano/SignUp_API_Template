using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Coffee_Shop_App.src.Enum;

namespace Coffee_Shop_App.src.Controllers;


public class UserController : BaseController //the inheritance to get the routing
{
    private IUserService? _userService; //to talk to the service
    public UserController(IUserService userService)
    {
        _userService = userService;
    }





    [HttpPatch("{Email}")]
    public UserReadDto? UpdateOne(string Email, [FromBody] UserCreateDto user)
    {
        return _userService!.UpdateOne(Email, user);
    }



    


    [HttpGet] //import the ASP.NetCore package
    [Authorize(Roles = "Admin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<UserReadDto>>? findAll()
    {
        return Ok(_userService!.FindAll()); //to send data to Service using Ok() method.
    }


    [HttpPost("signUp")] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<UserReadDto> SignUp([FromBody] UserCreateDto user)
    {
        if (user is not null)
        {
            var newUser = _userService!.SignUp(user); //sendin request to service
            return CreatedAtAction(nameof(SignUp), newUser); //return value in ActionResult

        }
        return BadRequest(); //built-in method for validation
    }


     [HttpPost("login")] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<string> Login([FromBody] UserLoginDto user)
    {
        if (user is not null)
        {
            string token  = _userService.Login(user); //sendin request to service
            if(token is null) //checking if the request is null
            {
                return BadRequest(); //the return for wrong login
            }

            return Ok(token); //return user login details as shaped in UserReadDto

        }
        return BadRequest(); //built-in method for validation
    }




    [HttpGet("{userId}")]
    public UserReadDto? findOne(Guid userId)
    {

        return _userService!.findOne(userId);
    }


    [HttpGet("userEmail")] //rename the route since we have duplicated endpoints
    public User? findOneByEmail(string userEmail)
    {

        return _userService!.findOneByEmail(userEmail); //call the method in the service
    }

}


