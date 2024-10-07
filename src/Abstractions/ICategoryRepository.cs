

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryRepository
{
    public IEnumerable<Category> FindAll(int limit, int offset);

    public Category? findOne(Guid categoryId);

    public Category CreateOne(Category category);

    public Category UpdateOne(Category updateCategory);

    public  Task<bool> DeleteOneAsync(Guid categoryId);




}
