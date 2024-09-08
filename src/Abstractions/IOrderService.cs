
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderService
    {
        public IEnumerable<OrderReadDto> FindAll();


        public OrderReadDto? FindOne(Guid orderId);

        public OrderReadDto CreateOne(OrderCreateDto order);



    }
}