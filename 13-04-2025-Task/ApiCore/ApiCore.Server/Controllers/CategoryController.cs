using Microsoft.AspNetCore.Mvc;
using ApiCore.Server.IDataService;
using ApiCore.Server.DTOs;


namespace ApiCore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService dataService)
        {
            _categoryService = dataService;
        }

        [HttpPost]
        public IActionResult AddCategory([FromForm] AddCategoryDto dto)
        {
            _categoryService.AddCategory(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCategory([FromForm] UpdateCategoryDto dto)
        {
            _categoryService.UpdateCategory(dto);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var result = _categoryService.GetAllCategories();
            return Ok(result);
        }
    }
}