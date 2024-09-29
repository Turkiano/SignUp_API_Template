using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions;

public interface IUserRepository
{

    public IEnumerable<User> FindAll(int limit, int offset);

    public User CreateOne(User user);

    public User? findOne(Guid userId);

    public User? findOneByEmail(string userEmail);

    public User UpdateOne(User updatedUser);






}
