
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderService
    {
        public IEnumerable<OrderReadDto> FindAll(int limit, int offset);


        public OrderReadDto? FindOne(Guid orderId);

        public OrderReadDto CreateOne(OrderCreateDto order);

        public OrderReadDto UpdateOne(Guid orderId, OrderUpdateDto updatedOrder);




    }
}