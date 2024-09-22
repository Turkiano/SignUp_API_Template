using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.Repositories;

class ProductRepository : IProductRepository
{
    private DatabaseContext _dbContext;
    private DbSet<Product> _products;


    public ProductRepository(DatabaseContext? dbContext)
    {
        _dbContext = dbContext!;
        // _products = _dbContext.Products!;
    }



    public IEnumerable<Product> FindAll(int limit, int offset)
    {
        if(limit == 0 && offset ==0){ // 1.if pagination has empty values
            return _dbContext.Products!; // 2.show all produts
        }
        // 3.else show the values of pagination
        return _dbContext.Products!.Skip(offset).Take(limit);
    }




    public Product CreateOne(Product product)
    {
        _dbContext.Add(product); //add into databas
        _dbContext.SaveChanges();//save into databas
        return product; //retun the new product details.

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