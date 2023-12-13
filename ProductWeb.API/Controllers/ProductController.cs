using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWeb.API.Application.Interfaces;
using ProductWeb.API.Core.Entities;
using ProductWeb.API.Core.Repositories;

namespace ProductWeb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productServices;
        public ProductController(IProductService productSerice)
        {
            _productServices = productSerice;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProductList()
        {
            try
            {
                var product = await _productServices.GetListAsync();
                if (product == null)
                { return NotFound(); }

                return Ok(product);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Encuontered error!");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetItemById(int id)
        {
            try
            {
                var product = await _productServices.GetListById(id);

                if (product == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(product);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }

    }
}
