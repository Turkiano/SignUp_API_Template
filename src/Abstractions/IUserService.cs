using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions
{

    public interface IUserService
    {


        public List<User> FindAll();
        // public UserReadDto SignUp(UserCreateDto user);
        // public string SignIn(UserSignInDto user);
        // public UserReadDto? FindOneByEmail(string email);
    }
}