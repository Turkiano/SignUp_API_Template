

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderItemRepository
    {
        public List<OrderItem> FindAll();

        public OrderItem? findOne(string orderItemId); //targeting ids in params

        public OrderItem CreateOne(OrderItem orderItem);


    }
}