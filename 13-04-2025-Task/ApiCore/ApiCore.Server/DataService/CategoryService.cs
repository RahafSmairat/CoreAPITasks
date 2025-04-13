using ApiCore.Server.Models;
using ApiCore.Server.IDataService;
using System;
using ApiCore.Server.DTOs;

namespace ApiCore.Server.DataService
{
    public class CategoryService : ICategoryService
    {
        private readonly MyDbContext _context;

        public CategoryService(MyDbContext context)
        {
            _context = context;
        }

        public void AddCategory(AddCategoryDto dto)
        {
            var category = new Category
            {
                CategoryName = dto.CategoryName,
                CategoryDesc = dto.CategoryDesc
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(UpdateCategoryDto dto)
        {
            var category = _context.Categories.Find(dto.Id);
            if (category == null) return;

            category.CategoryName = dto.CategoryName;
            category.CategoryDesc = dto.CategoryDesc;
            _context.SaveChanges();
        }

        public List<CategoryDto> GetAllCategories()
        {
            return _context.Categories
                .Select(c => new CategoryDto
                {
                    Id = c.Id,
                    CategoryName = c.CategoryName,
                    CategoryDesc = c.CategoryDesc
                }).ToList();
        }

    }
}
