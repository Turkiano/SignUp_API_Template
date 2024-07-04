

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src
{
    public interface IUserRepository
    {
        public List<User> FindAll();
    }
}