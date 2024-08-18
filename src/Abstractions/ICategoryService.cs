

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryService
{
        public List<Category> FindAll();
        public Category? findOne(string categoryId);


}
