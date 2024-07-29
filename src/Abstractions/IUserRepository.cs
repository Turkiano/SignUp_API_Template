using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_Appe.src.Abstractions
{
    public interface IUserRepository
    {

        public List<User> FindAll();
        
        public User CreateOne(User user);

        public User? findOne(string userId);

            public User? findOneByEmail(User userEmail);





    }
}