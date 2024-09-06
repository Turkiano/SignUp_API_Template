

using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderItemService
    {
    public IEnumerable<OrderItemReadDto> FindAll();

        public OrderItemReadDto? findOne(string orderItemId);

        public OrderItem CreateOne(OrderItem orderItem);





    }
}