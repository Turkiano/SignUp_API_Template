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

    public List<User> CreateOne(User user)
    {
        return _userRepository.CreateOne(user);
    }

    public List<User> FindAll()
    {
        return _userRepository.FindAll();
    }
   
}
