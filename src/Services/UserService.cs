using System.Text;

using Coffee_Shop_App.src.Utilities;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.DTOs;
using AutoMapper;

namespace Coffee_Shop_App.Services;

public class UserService : IUserService
{

    private IUserRepository? _userRepository; //to talk to the Repo
    private IConfiguration _config; //watch the demo (1. ASP.NET continue CRUD and Documentation)
    private IMapper _mapper; //to map DTO file with User entities

    public UserService(IUserRepository? userRepository, IConfiguration config, IMapper mapper) //constructor DI 
    {
        _userRepository = userRepository;
        _config = config;
        _mapper = mapper;
    }


    public List<UserReadDto> FindAll()
    {
        var users = _userRepository!.FindAll();//to talk to the Repo
        var usersRead = users.Select(_mapper.Map<UserReadDto>); //to use the DTO
        return  usersRead.ToList(); //to return data as a list
    }

    public UserReadDto findOne(string userId)
    {
        User? user = _userRepository!.findOne(userId); //to talk to the repo
        UserReadDto userRead = _mapper.Map<UserReadDto>(user); //to use the DTO
        return userRead;
    }





    public User CreateOne(User user)
    {
        User? foundUser = _userRepository!.findOneByEmail(user.Email); //to avoid duplicated emails

        if (foundUser is not null)
        {
            return null;
        }

        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPasswrod(user.Password, out string hashedPassword, pepper);

        user.Password = hashedPassword;

        return _userRepository.CreateOne(user);
    }

    public User? findOneByEmail(string userEmail)
    {

        return _userRepository!.findOneByEmail(userEmail);//call the method in the Repo

    }

    public User UpdateOne(string Email, User newValue)
    {
        User? user = _userRepository!.findOneByEmail(Email);

        if (user is not null)
        {
            user.FirstName = newValue.FirstName;
            return _userRepository.UpdateOne(user);
        }
        return null;
    }
}