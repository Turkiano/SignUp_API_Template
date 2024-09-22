using AutoMapper;

using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Abstractions;
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

    public ProductReadDto CreateOne(ProductCreateDto product)
    {
        Product foundProduct = _ProductRepository.FindOne(product.productId);
        if (foundProduct is not null)
        {
            return null;
        }
        Product mappedProduct = _mapper.Map<Product>(product);
        Product newProduct = _ProductRepository.CreateOne(mappedProduct);
        ProductReadDto readProduct = _mapper.Map<ProductReadDto>(newProduct);

       return readProduct;

    }

    public bool DeleteOne(Guid id)
    {
        Product product = _ProductRepository.FindOne(id);
        return _ProductRepository.DeleteOne(product.Id);
    }



    public IEnumerable<ProductReadDto> FindAll(int limit, int offset)
    {
        IEnumerable<Product> products =  _ProductRepository.FindAll(limit, offset);

        return products.Select(_mapper.Map<ProductReadDto>);
    }






    public ProductReadDto FindOne(Guid productId)
    {
        Product product = _ProductRepository.FindOne(productId);
        ProductReadDto productRead = _mapper.Map<ProductReadDto>(product);

        Console.WriteLine($"testing ");
        
        return productRead ;
    }

    public ProductReadDto UpdateOne(Guid Product_Id, ProductCreateDto updatedProduct)
    {
        Product? product = _ProductRepository.FindOne(Product_Id);
        if (product is not null) 
        {
            product.Name = updatedProduct.Name;
            Product mappedProduct = _mapper.Map<Product>(product);
            Product newProduct =  _ProductRepository.UpdateOne(mappedProduct);
            ProductReadDto productRead = _mapper.Map<ProductReadDto>(newProduct);
            return productRead;
        }
        return null;
    }
}