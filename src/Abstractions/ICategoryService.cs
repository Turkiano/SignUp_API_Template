

using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryService
{
    public IEnumerable<CategoryReadDto> FindAll(int limit, int offset);
    public CategoryReadDto? findOne(Guid categoryId);

    public CategoryReadDto CreateOne(CategoryCreateDto category);


    public CategoryReadDto UpdateOne(Guid CategoryId, CategoryCreateDto updatedCategory);




}
