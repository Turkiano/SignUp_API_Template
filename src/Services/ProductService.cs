using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.Services;

class ProductService : IProductService
{
    private IProductRepository _ProductRepository; //to talk to the Repo

    public ProductService(IProductRepository productRepository)
    {
        _ProductRepository = productRepository;
    }

    public Product CreateOne(Product product)
    {
        return _ProductRepository.CreateOne(product);
    }

    public List<Product> FindAll()
    {
        return _ProductRepository.FindAll();
    }

    public Product FindOne(string productId)
    {
        return _ProductRepository.FindOne(productId);
    }

    public Product UpdateOne(string Product_Id, Product updatedProduct)
    {
        Product? product = _ProductRepository.FindOne(Product_Id);
        if (product is not null) 
        {
            product.Product_Name = updatedProduct.Product_Name;
            return _ProductRepository.UpdateOne(product);
        }
        return null;
    }
}