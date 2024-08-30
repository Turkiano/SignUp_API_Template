using AutoMapper;

using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Services;

class ProductService : IProductService
{
    private IProductRepository _ProductRepository; //to talk to the Repo

    private IMapper _mapper;
    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _ProductRepository = productRepository;
        _mapper = mapper;
    }

    public Product CreateOne(Product product)
    {
        return _ProductRepository.CreateOne(product);
    }

    public List<ProductReadDto> FindAll()
    {
        var product = _ProductRepository.FindAll();
        var productRead = product.Select(_mapper.Map<ProductReadDto>);

        return productRead.ToList();
    }

    public ProductReadDto FindOne(string productId)
    {
        Product product = _ProductRepository.FindOne(productId);
        ProductReadDto productRead = _mapper.Map<ProductReadDto>(product);

        Console.WriteLine($"testing ");
        
        return productRead ;
    }

    public ProductReadDto UpdateOne(string Product_Id, ProductCreateDto updatedProduct)
    {
        Product? product = _ProductRepository.FindOne(Product_Id);
        if (product is not null) 
        {
            product.Name = updatedProduct.Product_Name;
            Product mappedProduct = _mapper.Map<Product>(product);
            Product newProduct =  _ProductRepository.UpdateOne(mappedProduct);
            ProductReadDto productRead = _mapper.Map<ProductReadDto>(newProduct);
            return productRead;
        }
        return null;
    }
}