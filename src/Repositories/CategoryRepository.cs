using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;


namespace Coffee_Shop_App.Repositories;


    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public CategoryRepository()
        { 
            _categories = new DatabaseContext().categories;
        }

        public List<Category> FindAll()
        {
            return _categories;
        }
    }

