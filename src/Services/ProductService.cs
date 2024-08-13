using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App;

class ProductSerice : IProductService
{


    private IProductRepository _ProductRepository;

    public ProductSerice(IProductRepository productRepository)
    {
        _ProductRepository = productRepository;
    }

    public Product findOne(string productId)
    {
        return _ProductRepository.findOne(productId);
    }
}