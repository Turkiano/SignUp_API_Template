using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Repositories
{

    public class UserRepository : IUserRepository
    {
        // private DatabaseContext _database;
        // private List<> _databaseContext;
        private List<User> _users;
        public UserRepository()
        {
            _users = user;
            // _databaseContext = databaseContext;

        }

        public List<User> FindAll()
        {
            return user;
        }


            public User CreateOne(User user)
        {
            _users.Add(user);
            // _databaseContext.SaveChanges();
            return user;
        }


    }



}