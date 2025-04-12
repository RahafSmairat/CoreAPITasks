using ApiCore.Server.Models;
namespace ApiCore.Server.IDataService
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        Category GetByName(string name);
        void Delete(int id);
    }
}
