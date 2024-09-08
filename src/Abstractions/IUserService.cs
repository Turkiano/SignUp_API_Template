using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;


public interface IUserService
{


    public List<UserReadDto> FindAll();

    public UserReadDto SignUp(UserCreateDto user);

    public UserReadDto findOne(Guid userId);

    public User findOneByEmail(string userEmail);

    public UserReadDto UpdateOne(string Email, UserCreateDto updatedUser);


}
