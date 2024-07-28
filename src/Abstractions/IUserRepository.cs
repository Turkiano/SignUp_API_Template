using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_Appe.src.Abstractions
{
    public interface IUserRepository
    {

        public List<User> FindAll();
        
        public List<User> CreateOne(User user);

        public User? findOne(string userId);




    }
}