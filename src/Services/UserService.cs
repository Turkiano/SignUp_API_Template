
using Coffee_Shop_App.src.Repositories;

namespace Coffee_Shop_App.src.Services;



public class UserService
{

    public string SayHi()
    {
        var helloRepository = new UserRepository();
        return helloRepository.SayHi();

    }


}
