using ProductWeb.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetListAsync();
        Task<Product> GetProductById(int Id);
    }
}
