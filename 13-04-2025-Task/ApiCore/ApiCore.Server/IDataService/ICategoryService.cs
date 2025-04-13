using ApiCore.Server.DTOs;
using ApiCore.Server.Models;
namespace ApiCore.Server.IDataService
{
    public interface ICategoryService
    {
        void AddCategory(AddCategoryDto dto);
        void UpdateCategory(UpdateCategoryDto dto);
        List<CategoryDto> GetAllCategories();
    }
}
