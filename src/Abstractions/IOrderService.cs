
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderService
    {
        public IEnumerable<Order> FindAll();


        public OrderReadDto? FindOne(string orderId);

        public Order CreateOne(Order order);



    }
}