using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_API_Server;

class ProductRepository : IProductRepository
{
        private List<Product> _products;

    public ProductRepository()
    {
        _products = new DatabaseContext().products;
    }



    // private List<User>? _users; //this to get users info as a list
    // public UserRepository() //constructor to get users data from DB
    // {

    //     _users = new DatabaseContext().users; // new obj database to get users' list

    // }
    public Product findOne(string productId)
    {
        throw new NotImplementedException();
    }
}