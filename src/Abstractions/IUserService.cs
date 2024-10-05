using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;


public interface IUserService
{


    public IEnumerable<UserReadDto> FindAll(int limit, int offset);

    public UserReadDto SignUp(UserCreateDto user);

    public string Login(UserLoginDto userLogin);

    public UserReadDto findOne(Guid userId);

    public UserReadDto findOneByEmail(string userEmail);

    public UserReadDto UpdateOne(string Email, UserCreateDto updatedUser);


}
