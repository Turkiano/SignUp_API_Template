using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App;

class ProductSerice : IProductService
{
    private IProductRepository _ProductRepository; //to talk to the Repo

    public ProductSerice(IProductRepository productRepository)
    {
        _ProductRepository = productRepository;
    }

    public List<Product> findAll()
    {
        return _ProductRepository.findAll();
    }

    public Product findOne(string productId)
    {
        return _ProductRepository.findOne(productId);
    }
}