using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.Repositories;

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


    public List<User> CreateOne(){
        var users = _userRepository.CreateOne();
        return users;
        
    }
}
