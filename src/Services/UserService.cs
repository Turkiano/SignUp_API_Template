using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Services;



public class UserService : IUserService
{


    private IUserRepository _userRepository; //private field using interface class

    public UserService(IUserRepository userRepository) //constructor
    { 

        _userRepository = userRepository;
    }
    public List<User> FindAll()
    {
        var users = _userRepository.FindAll();
        return users;

    }
}
