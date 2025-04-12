using Microsoft.AspNetCore.Mvc;
using ApiCore.Server.IDataService;


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

        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_categoryService.GetAll());
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            return Ok(category);
        }

        [HttpGet("name")]
        public IActionResult GetByName(string name)
        {
            var category = _categoryService.GetByName(name);
            return Ok(category);
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return NoContent();
        }

        //    private readonly MyDbContext _context;
        //    public CategoryController(MyDbContext _db) 
        //    {
        //        _context = _db;
        //    }

        //    [HttpGet("GetAllCategories")]
        //    public IActionResult GetAllCategories()
        //    {
        //        var categories = _context.Categories.ToList();

        //        return Ok(categories);
        //    }

        //    [HttpGet("GetFirstCategory")]
        //    public IActionResult GetFirstCategory()
        //    {
        //        var firstCategory = _context.Categories.FirstOrDefault();

        //        return Ok(firstCategory);
        //    }

        //    [HttpGet("GetCategoryByID")]
        //    public IActionResult GetCategoryByID(int id)
        //    {
        //        var category = _context.Categories.Find(id);

        //        return Ok(category);
        //    }

        //    [HttpGet("GetCategoryByName")]
        //    public IActionResult GetCategoryByName(string name)
        //    {
        //        var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);

        //        return Ok(category);
        //    }

        //    //////////////////////////////////////////////////////////////////////////////////////

        //    [HttpGet("GetAllProducts")]
        //    public IActionResult GetAllProducts()
        //    {
        //        var products = _context.Products.ToList();

        //        return Ok(products);
        //    }

        //    [HttpGet("GetFirstProduct")]
        //    public IActionResult GetFirstProduct()
        //    {
        //        var firstProduct = _context.Products.FirstOrDefault();

        //        return Ok(firstProduct);
        //    }

        //    [HttpGet("GetProductByID")]
        //    public IActionResult GetProductByID(int id)
        //    {
        //        var product = _context.Products.Find(id);

        //        return Ok(product);
        //    }

        //    [HttpGet("GetProductByName")]
        //    public IActionResult GetProductByName(string name)
        //    {
        //        var product = _context.Products.FirstOrDefault(c => c.Name == name);

        //        return Ok(product);
        //    }
        //}
    }
}