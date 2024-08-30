using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Repositories;
 
public class UserRepository : IUserRepository
{

    private DbSet<User>? _users; //this to get users info as a list
    public UserRepository( DatabaseContext databaseContext) //constructor to get users data from DB
    {

        _users =  databaseContext.Users; // new obj database to get users' list

    }

    public IEnumerable<User> FindAll()
    {

        return _users!;

    }
    
    public User CreateOne(User user)
    {
        _users?.Add(user); // temporary saving data
        return user; //to show new user only
    }


    public User? findOne(string userId) //targeting ids in params
    {
        User? user = _users?.FirstOrDefault(user => user.Id == userId); //lambda expression to compare Ids

        return user; //to get the desired user
    }

    public User? findOneByEmail(string userEmail)
    {
        User? foundEmail = _users?.FirstOrDefault(user => user.Email == userEmail); //lambda expression to compare Emails

        return foundEmail;
    }

    public User UpdateOne(User updatedUser)
    {
        // var users = _users?.Select(user =>
        // {
        //     if (user.Email == updatedUser.Email)
        //     {
        //         return updatedUser;
        //     }
        //     return user;
        // });
        // _users = users!.ToList();
        return updatedUser;
    }
}