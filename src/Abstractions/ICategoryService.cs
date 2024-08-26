

using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface ICategoryService
{
    public List<CategoryReadDto> FindAll();
    public CategoryReadDto? findOne(string categoryId);

    public CategoryReadDto CreateOne(CategoryCreateDto category);


    public CategoryReadDto UpdateOne(string CategoryId, CategoryCreateDto updatedCategory);




}
