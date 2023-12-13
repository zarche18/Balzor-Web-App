using ProductWeb.API.Core.Entities;
using ProductWeb.API.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using ProductWeb.API.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Infrastructure.Repository
{
    public class ProductsRepository : IProductRepository
    {
        private readonly ProductWebDbContext _context;

        public ProductsRepository(ProductWebDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetListAsync()
        {
            return await _context.products.ToListAsync();
        }
        public async Task<Product> GetProductById(int Id)
        {
            try
            {
                var product = await _context.products.SingleOrDefaultAsync(i => i.ID == Id);

                if (product != null)
                {
                    return product;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
