using ApiCore.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService _ser)
        {
            _service = _ser;
        }

        [HttpGet("getAllProducts")]
        public IActionResult getAllProducts()
        {
            return Ok(_service.getAllProducts());
        }

        [HttpGet("getProductById/{id}")]
        public IActionResult getProductById(int id)
        {
            return Ok(_service.getProductByID(id));
        }

        [HttpGet("getProductByName/{name}")]
        public IActionResult getProductByName(string name)
        {
            return Ok(_service.getProductByName(name));
        }

        [HttpDelete]
        public IActionResult deleteProduct(int id)
        {
            _service.deleteProduct(id);
            return NoContent();
        }
    }
}
