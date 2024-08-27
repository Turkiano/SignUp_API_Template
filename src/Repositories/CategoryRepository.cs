using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;


namespace Coffee_Shop_App.Repositories;


public class CategoryRepository : ICategoryRepository
{
    private DbSet<Category> _categories;

    public CategoryRepository(DatabaseContext databaseContext)
    {
        _categories = databaseContext.Categories;
    }

    public Category CreateOne(Category category)
    {
        _categories.Add(category);
        return category;
    }

    public IEnumerable<Category> FindAll()
    {
        return _categories;
    }



    public Category findOne(string categoryId)
    {
        Category? category = _categories?.FirstOrDefault(category => category.CategoryId == categoryId); //lambda expression to compare Ids

        return category; //to get the desired user
        throw new NotImplementedException();
    }

    public Category UpdateOne(Category updateCategory)
    {
        // var category = _categories.Select(category =>
        // {
        //     if (category.CategoryId == updateCategory.CategoryId)
        //     {
        //         return updateCategory;
        //     }
        //     return category;
        // });
        // _categories = category.ToList();
        return updateCategory;
    }

   
}

