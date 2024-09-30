using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;


namespace Coffee_Shop_App.Repositories;


public class CategoryRepository : ICategoryRepository
{
    private DatabaseContext _dbContext;
    private DbSet<Category> _categories;

    public CategoryRepository(DatabaseContext databaseContext, DatabaseContext dbContext)
    {
        _categories = databaseContext.Categories;
        _dbContext = dbContext;
    }

    public Category CreateOne(Category category)
    {
        _dbContext.Add(category);
        _dbContext.SaveChanges();
        return category;
    }

    public IEnumerable<Category> FindAll(int limit, int offset)
    {
        if (limit == 0 && offset == 0)
        { // 1.if pagination has empty values
            return _dbContext.Categories!; // 2.show all produts
        }
        // 3.else show the values of pagination
        return  _dbContext.Categories!.Skip(offset).Take(limit);;
    }



    public Category findOne(Guid categoryId)
    {
        Category? category = _categories?.FirstOrDefault(category => category.CategoryId == categoryId); //lambda expression to compare Ids

        return category; //to get the desired user

    }

    public Category UpdateOne(Category updateCategory)
    {

        return updateCategory;
    }


}

