using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions;

public interface IUserRepository
{

    public IEnumerable<User> FindAll();

    public User CreateOne(User user);

    public User? findOne(string userId);

    public User? findOneByEmail(string userEmail);

    public User UpdateOne(User updatedUser);






}
