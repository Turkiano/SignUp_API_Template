using Coffee_Shop_App.src.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Abstractions
{

    public interface IUserService
    {


        public List<User> FindAll();

        public User CreateOne(User user);

        public User? findOne(string userId);

        public User? findOneByEmail(string userEmail);

        public User UpdateOne(string Email, User user);




    }
}