using Microsoft.AspNetCore.Components;
using ProductWeb.API.Core.Entities;
using ProductWeb.Services.Contracts;

namespace ProductWeb.Pages
{
    public class ProductDetailBase:ComponentBase
    {
        [Parameter] 
        public int Id { get; set; }
        public Product Product { get; set; }

        [Inject]
        public IProductService ProductService { get; set; } 

        private async Task<Product> GetProductById(int id)
        {
            var products = await ProductService.GetItems();

            if (products != null)
            {
                return products.SingleOrDefault(p => p.ID == id);
            }
            return null;
        }
        protected override async Task OnInitializedAsync()
        {
            var products = await ProductService.GetItemById(Id);
            Product = products;
        }
    }
}
