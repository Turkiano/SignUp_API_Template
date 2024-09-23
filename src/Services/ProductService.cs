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
        Product product = _ProductRepository.FindOne(id); //to find the desired product
        if(product is null) return false; //to check if the product is found or not
         _ProductRepository.DeleteOne(product); //to send the request to the repo
        return true;
    }


 
    public IEnumerable<ProductReadDto> FindAll(int limit, int offset)
    {
        IEnumerable<Product> products =  _ProductRepository.FindAll(limit, offset);

        return products.Select(_mapper.Map<ProductReadDto>);
    }





    public ProductReadDto FindOne(Guid productId)
    {
        Product product = _ProductRepository.FindOne(productId);
        if(product is null) return null; // to show null, if product was not found
        ProductReadDto productRead = _mapper.Map<ProductReadDto>(product);

        
        return productRead ;
    }






    public ProductReadDto UpdateOne(Guid productId, ProductUpdateDto updatedProduct)
    {
        Product? product = _ProductRepository.FindOne(productId); // 1)To find the desired product
        if(product is null) return null; // 2)To stop if product is not found

        //3)this to pass the desired properties to be updated:
        product.Name = updatedProduct.Name;
        product.CategoryId = updatedProduct.CategoryId;
        
         _ProductRepository.UpdateOne(product);//4) Send the request to the repository.

        return _mapper.Map<ProductReadDto>(product);//5) Map the request to the productReadDTO.
    }
}