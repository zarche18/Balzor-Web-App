using AutoMapper.Internal.Mappers;
using ProductWeb.API.Core.Repositories;
using ProductWeb.API.Application.Interfaces;
using ProductWeb.API.Application.Mapper;
using ProductWeb.API.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<IEnumerable<ProductModel>> GetListAsync()
        {
            try
            {
                var result = await _productRepository.GetListAsync();

                var mapped = ObjectMapper.Mapper.Map<IEnumerable<ProductModel>>(result);
                return mapped;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        async Task<ProductModel> IProductService.GetListById(int Id)
        {
            try
            {
                var result = await _productRepository.GetProductById(Id);

                var mapped = ObjectMapper.Mapper.Map<ProductModel>(result);
                return mapped;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
