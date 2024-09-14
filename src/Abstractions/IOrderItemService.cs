

using Coffee_Shop_App.src.DTOs;

namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderItemService
    {
    public IEnumerable<OrderItemReadDto> FindAll();

        public OrderItemReadDto? findOne(Guid orderItemId);

        public OrderItemReadDto CreateOne(OrderItemCreateDto orderItem);





    }
}