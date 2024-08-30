using System.Text;
using AutoMapper;

using Coffee_Shop_App.src.Utilities;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.DTOs;

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





    public UserReadDto CreateOne(UserCreateDto user)
    {
        User? foundUser = _userRepository!.findOneByEmail(user.Email); //to avoid duplicated emails

        if (foundUser is not null)
        {
            return null;
        }

        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPasswrod(user.Password, out string hashedPassword, pepper);

        user.Password = hashedPassword;
        
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