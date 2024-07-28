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
    public List<User> CreateOne(User user)
    {
        _users?.Add(user); //to save data in temporary
        return _users; //to send data to User list
    }


    public User? findOne(string userId)
    {
        User? user = _users?.FirstOrDefault( user => user.Id == userId);
        
        return user; 
    }
}