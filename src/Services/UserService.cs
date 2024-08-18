using System.Text;

using Coffee_Shop_App.src.Utilities;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

public class UserService : IUserService
{

    private IUserRepository? _userRepository; //to talk to the Repo
    private IConfiguration _config;

    public UserService(IUserRepository? userRepository, IConfiguration config) //constructor DI 
    {
        _userRepository = userRepository;
        _config = config;
    }



    public List<User> FindAll()
    {
        return _userRepository.FindAll(); //to talk to the Repo
    }



    public User CreateOne(User user)
    {
        User? foundUser = _userRepository.findOneByEmail(user.Email); //to avoid duplicated emails

        if (foundUser is not null)
        {
            return null;
        }

        byte[] pepper = Encoding.UTF8.GetBytes(_config["Jwt:Pepper"]!);
        PasswordUtils.HashPasswrod(user.Password, out string hashedPassword, pepper);

        user.Password = hashedPassword;

        return _userRepository.CreateOne(user);
    }


    public User? findOne(string userId)
    {

        return _userRepository.findOne(userId);
    }

    public User? findOneByEmail(string userEmail)
    {

        return _userRepository.findOneByEmail(userEmail);//call the method in the Repo

    }

    public User UpdateOne(string Email, User newValue)
    {
        User? user = _userRepository.findOneByEmail(Email);

        if (user is not null)
        {
            user.FirstName = newValue.FirstName;
            return _userRepository.UpdateOne(user);
        }
        return null;
    }
}