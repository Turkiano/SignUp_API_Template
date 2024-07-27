using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_Appe.src.Abstractions;

namespace Coffee_Shop_App;

public class UserService : IUserService
{

  private IUserRepository? _userRepository; //to talk to the Repo

    public UserService(IUserRepository? userRepository) //constructor DI 
    {
        _userRepository = userRepository;
    }




    public List<User> FindAll()
    {
        return _userRepository.FindAll(); //to talk to the Repo
    }
}