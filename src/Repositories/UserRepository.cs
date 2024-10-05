using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Repositories;

public class UserRepository : IUserRepository
{
    private DatabaseContext _dbContext;
    private DbSet<User>? _users; //this to get users info as a list
    public UserRepository(DatabaseContext dbContext) //constructor to get users data from DB
    {

        _users = dbContext.Users; // new obj database to get users' list
        _dbContext = dbContext;

    }

    public IEnumerable<User> FindAll(int limit, int offset)
    {
        if (limit == 0 && offset == 0)
        { // 1.if pagination has empty values
            return _dbContext.Users!; // 2.show all produts
        }
        // 3.else show the values of pagination
        return _dbContext.Users!.Skip(offset).Take(limit);

    }

    public User CreateOne(User user)
    {
        _dbContext.Add(user); // temporary saving data
        _dbContext.SaveChanges();
        return user; //to show new user only
    }


    public User? findOne(Guid userId) //targeting ids in params
    {
        // User? user = _users?.FirstOrDefault(user => user.Id == userId); //lambda expression to compare Ids

        return _dbContext.Users.Find(userId); //to get the desired user
    }

    public User? findOneByEmail(string userEmail)
    {
        // User? foundEmail = _users?.FirstOrDefault(user => user.Email == userEmail); //lambda expression to compare Emails
        User? foundUser = _dbContext.Users.FirstOrDefault(u => u.Email == userEmail);
        return foundUser;

    }

    public User UpdateOne(User updatedUser)
    {
        _dbContext.Users.Update(updatedUser);
        _dbContext.SaveChanges();


        return updatedUser;
    }
}