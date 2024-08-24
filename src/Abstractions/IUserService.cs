using Coffee_Shop_App.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;


public interface IUserService
{


    public List<UserReadDto> FindAll();

    public UserReadDto CreateOne(UserCreateDto user);

    public UserReadDto findOne(string userId);

    public User findOneByEmail(string userEmail);

    public User UpdateOne(string Email, User user);


}
