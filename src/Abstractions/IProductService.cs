
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface IProductService
{
    public ProductReadDto FindOne(Guid productId);

    public List<ProductReadDto> FindAll();

    public Product CreateOne(Product product);

    public ProductReadDto UpdateOne(Guid Product_Id, ProductCreateDto updatedProduct);




}
