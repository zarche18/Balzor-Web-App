using Microsoft.AspNetCore.Components;
using ProductWeb.API.Core.Entities;
using ProductWeb.Services.Contracts;

namespace ProductWeb.Pages
{
    public class ProductBase:ComponentBase
    {

        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<Product> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var products = await ProductService.GetItems();
            Products = products;
        }
    }
}
