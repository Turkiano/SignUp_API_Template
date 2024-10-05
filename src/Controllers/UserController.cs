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





    [HttpPatch("{email}")]
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserReadDto?> UpdateOne(string email, [FromBody] UserCreateDto user)
    {
        UserReadDto theUser = _userService.UpdateOne(email, user);
        if (theUser is null) return NotFound();

        return Accepted(theUser);
    }






    [HttpGet] //import the ASP.NetCore package
    // [Authorize(Roles = "Admin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<UserReadDto>>? findAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        return Ok(_userService!.FindAll(limit, offset)); //to send data to Service using Ok() method.
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
            string token = _userService.Login(user); //sendin request to service
            if (token is null) //checking if the request is null
            {
                return BadRequest(); //the return for wrong login
            }

            return Ok(token); //return user login details as shaped in UserReadDto

        }
        return BadRequest(); //built-in method for validation
    }




    [HttpGet("{userId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserReadDto?> findOne(Guid userId)
    {
        UserReadDto user = _userService!.findOne(userId);
        if (user is null) return NotFound();

        return Ok(user);
    }


    [HttpGet("email")] //rename the route since we have duplicated endpoints
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<UserReadDto?> findOneByEmail(string email)
    {
        UserReadDto user = _userService.findOneByEmail(email); //call the method in the service
        if (user is null) return NotFound();

        return Ok(user);
    }

}


