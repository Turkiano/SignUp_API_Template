
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface IProductService
{
    public ProductReadDto FindOne(string productId);

    public List<Product> FindAll();

    public Product CreateOne(Product product);

    public Product UpdateOne(string Product_Id, Product updatedProduct);




}
