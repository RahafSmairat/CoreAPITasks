using ApiCore.Server.Models;
using ApiCore.Server.IDataService;

namespace ApiCore.Server.DataService
{
    public class ProductService : IProductService
    {
        private readonly MyDbContext _context;

        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public List<Product> getAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product getProductByID(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product getProductByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public void deleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
