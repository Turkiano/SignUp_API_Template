using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.Repositories;
using Coffee_Shop_Appe.src.Abstractions;

namespace Coffee_Shop_App.src.Services;



public class UserService 
{

    public string SayHi(){
        var helloRepository = new UserRepository();
        return helloRepository.SayHi();

    }


}
