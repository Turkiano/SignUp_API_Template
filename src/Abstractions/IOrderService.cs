
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderService
    {
        public List<Order> FindAll();

    }
}