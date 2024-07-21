using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Repositories
{

    public class UserRepository : IUserRepository
    {
        // private DatabaseContext _database;
        // private List<> _databaseContext;
        private List<User> _users;
        public UserRepository(User users)
        {
            // _users = users;
            

            // _databaseContext = databaseContext;

        }

        public List<User> CreateOne(User users)
        {
            return _users;
        }

        public List<User> FindAll()
        {
            return _users;
        }
    }

}