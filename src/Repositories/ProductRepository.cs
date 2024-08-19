using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Repositories;

class ProductRepository : IProductRepository
{
    private List<Product> _products;

    public ProductRepository()
    {
        _products = new DatabaseContext().products;
    }

    public Product CreateOne(Product product)
    {
        _products.Add(product);
        return (product);

    }

    public List<Product> FindAll()
    {
        return _products;
    }

    public Product FindOne(string productId)
    {
        Console.WriteLine($"testing = {productId}");


        Product? product = _products?.FirstOrDefault(p => p.Product_Id == productId); //lambda expression to compare Ids

        return product;

    }

    public Product UpdateOne(Product updatedProduct)
    {
        var products = _products.Select(product =>
        {
            if (product.Product_Id == updatedProduct.Product_Id){
                return updatedProduct;
            }

            return product;
        });
        _products = products.ToList();
        return updatedProduct;
    }
}