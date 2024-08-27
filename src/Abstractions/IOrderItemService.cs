

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderItemService
    {
    public IEnumerable<OrderItem> FindAll();

        public OrderItem? findOne(string orderItemId);

        public OrderItem CreateOne(OrderItem orderItem);





    }
}