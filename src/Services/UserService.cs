using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App;

public class UserService : IUserService
{

    private List<User>? _users; //this to get users info as a list
    public UserService() //constructor to get users data from DB
    {

        _users = new DatabaseContext().users; // new obj database to get users' list

    }



    public List<User> FindAll()
    {
        return _users;
    }
}