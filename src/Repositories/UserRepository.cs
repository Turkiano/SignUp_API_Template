using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_Appe.src.Abstractions;

namespace Coffee_Shop_App;

public class UserRepository : IUserRepository
{

    private List<User>? _users; //this to get users info as a list
    public UserRepository() //constructor to get users data from DB
    {

        _users = new DatabaseContext().users; // new obj database to get users' list

    }

    public List<User> FindAll()
    {

        return _users;

    }
}