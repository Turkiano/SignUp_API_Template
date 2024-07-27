using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Abstractions
{

    public interface IUserService
    {


        public List<User> FindAll();
        // public List<User> CreateOne([FromBody] User user);



    }
}