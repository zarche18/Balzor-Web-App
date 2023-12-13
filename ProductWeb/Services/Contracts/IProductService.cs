using ProductWeb.API.Core.Entities;

namespace ProductWeb.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetItems();
        Task<Product> GetItemById(int id);
    }
}
