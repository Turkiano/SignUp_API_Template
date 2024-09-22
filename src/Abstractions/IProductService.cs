
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface IProductService
{
        public IEnumerable<ProductReadDto> FindAll(int limit, int offset);

    public ProductReadDto FindOne(Guid productId);


    public ProductReadDto CreateOne(ProductCreateDto product);

    public ProductReadDto UpdateOne(Guid Product_Id, ProductCreateDto updatedProduct);




}
