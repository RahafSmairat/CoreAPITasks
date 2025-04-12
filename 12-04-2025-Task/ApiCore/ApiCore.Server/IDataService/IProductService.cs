using ApiCore.Server.Models;

namespace ApiCore.Server.IDataService
{
    public interface IProductService
    {
        List<Product> getAllProducts();
        Product getProductByID(int id);
        Product getProductByName(string name);
        void deleteProduct(int id);
    }
}
