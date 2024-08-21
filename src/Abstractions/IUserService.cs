using Coffee_Shop_App.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;


public interface IUserService
{


    public List<User> FindAll();

    public User CreateOne(User user);

    public UserReadDto findOne(string userId);

    public User findOneByEmail(string userEmail);

    public User UpdateOne(string Email, User user);




}
