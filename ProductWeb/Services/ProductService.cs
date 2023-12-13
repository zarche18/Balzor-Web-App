using ProductWeb.API.Core.Entities;
using ProductWeb.Services.Contracts;
using System.Net.Http;
using System.Net.Http.Json;

namespace ProductWeb.Services
{
    public class ProductService:IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        } 

        async Task<IEnumerable<Product>> IProductService.GetItems()
        {
            try
            {
                var products = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/Product");
                return products;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<Product> GetItemById(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Product/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(Product);
                    }

                    return await response.Content.ReadFromJsonAsync<Product>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                }
            }
            catch (Exception)
            {
                //Log exception
                throw;
            }
        }
    }
}
