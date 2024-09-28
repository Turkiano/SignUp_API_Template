using System.Text;
using AutoMapper;

using Coffee_Shop_App.src.Utilities;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.Repositories;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Coffee_Shop_App.Services;

public class UserService : IUserService
{

    private IUserRepository? _userRepository; //to talk to the Repo
    private IConfiguration _config; // (configure pepper) watch the demo (1. ASP.NET continue CRUD and Documentation)
    private IMapper _mapper; //to map DTO file with User entities

    public UserService(IUserRepository? userRepository, IConfiguration config, IMapper mapper) //constructor DI 
    {
        _userRepository = userRepository;
        _config = config;
        _mapper = mapper;
    }


    public string Login(UserLoginDto userLogin)
    {

        User user = _userRepository.findOneByEmail(userLogin.Email); //1.find the user
        if (user is not null) return null; //2.the early return concept


        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);//3.A. Declare the pepper
        bool CorrectPassword = PasswordUtils.VerifyPassword(userLogin.Password, user.Password, pepper); //3.B. Compare passwords
        if (!CorrectPassword) return null; //4.Early return (2) checking if wrong pass, return null.


//to generate a Token, require the following

        var claims = new[]{//1. The claims
            new Claim(ClaimTypes.Name, user.FirstName),
            new Claim(ClaimTypes.Role, user.Role.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
       };

       var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SigningKey"]!));
       var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
       var token = new JwtSecurityToken(
        issuer: _config["Jwt:Issuer"], //Replace with your own back-end
        audience: _config["Jwt:Audience"], //Replace your own front-end
        claims: claims,
        expires: DateTime.Now.AddDays(7), //Token epiration time
        signingCredentials: creds
       );

       var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
       return tokenString;
    }

    public List<UserReadDto> FindAll()
    {
        var users = _userRepository!.FindAll();//to talk to the Repo
        var usersRead = users.Select(_mapper.Map<UserReadDto>); //to use the DTO
        return usersRead.ToList(); //to return data as a list
    }



    public UserReadDto findOne(Guid userId)
    {
        User? user = _userRepository!.findOne(userId); //to talk to the repo
        UserReadDto userRead = _mapper.Map<UserReadDto>(user); //to use the DTO
        return userRead;
    }





    public UserReadDto SignUp(UserCreateDto user)
    {
        User? foundUser = _userRepository!.findOneByEmail(user.Email); //to avoid duplicated emails

        if (foundUser is not null)
        {
            return null;
        }

        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!); //configure the pepper from appsettings
        PasswordUtils.HashPasswrod(user.Password, out string hashedPassword, pepper); //hashing pepper + password

        user.Password = hashedPassword; //assigning passwords with hashed password

        User mappedUser = _mapper.Map<User>(user); //01.to map the request of create user 
        User newUser = _userRepository.CreateOne(mappedUser);//02.to pass the newUser to the repo
        UserReadDto userRead = _mapper.Map<UserReadDto>(newUser);//03.to covert user obj to UserReadDto

        return userRead;//04. return the ReadDto 

    }






    public User? findOneByEmail(string userEmail)
    {

        return _userRepository!.findOneByEmail(userEmail);//call the method in the Repo

    }

    public UserReadDto UpdateOne(string Email, UserCreateDto updatedUser)
    {
        User? user = _userRepository!.findOneByEmail(Email);

        if (user is not null)
        {
            user.FirstName = updatedUser.FirstName;
            User mappedUser = _mapper.Map<User>(user);
            User newUser = _userRepository.UpdateOne(mappedUser);
            UserReadDto userRead = _mapper.Map<UserReadDto>(newUser);
            return userRead;
        }
        return null;
    }
}