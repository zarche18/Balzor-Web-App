using ProductWeb.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetListAsync();
        Task<ProductModel> GetListById(int Id); 
    }
}
