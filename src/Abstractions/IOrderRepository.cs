

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions
{
    public interface IOrderRepository
    {
            public List<Order> FindAll();

    }
}