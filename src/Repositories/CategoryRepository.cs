using Coffee_Shop_API_Server.src.Abstractions;
using Coffee_Shop_App.src.Databases;

namespace Coffee_Shop_API_Server
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public CategoryRepository(List<Category> categories)
        {
            _categories = new DatabaseContext().categories;
        }

        public List<Category> FindAll()
        {
            return _categories;
        }
    }
}
