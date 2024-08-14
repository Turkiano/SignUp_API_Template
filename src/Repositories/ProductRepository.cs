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

    public Product CreateOne(Product product)
    {
        throw new NotImplementedException();
    }

    public List<Product> FindAll()
    {
        return _products;
    }

    public Product FindOne(string productId)
    {

        Product? product = _products?.FirstOrDefault(p => p.Product_Id == productId); //lambda expression to compare Ids

        return product;

    }


}