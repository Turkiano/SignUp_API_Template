using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Repositories;

class ProductRepository : IProductRepository
{
    private DbSet<Product> _products;

    public ProductRepository(DatabaseContext databaseContext)
    {
        _products = databaseContext.Products;
    }

    public Product CreateOne(Product product)
    {
        _products.Add(product);
        return (product);

    }

    public IEnumerable<Product> FindAll()
    {
        return _products;
    }

    public Product FindOne(Guid productId)
    {
        Console.WriteLine($"testing = {productId}");


        Product? product = _products?.FirstOrDefault(product => product.Id == productId); //lambda expression to compare Ids

        return product!;

    }

    public Product UpdateOne(Product updatedProduct)
    {
       
        return updatedProduct;
    }
}