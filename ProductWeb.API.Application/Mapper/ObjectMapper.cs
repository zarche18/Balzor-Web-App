using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Transactions;
using AutoMapper;
using ProductWeb.API.Core.Entities;
using ProductWeb.API.Application.Models;

namespace ProductWeb.API.Application.Mapper
{
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<OnlineShopDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
    public class OnlineShopDtoMapper : Profile
    {
        public OnlineShopDtoMapper()
        {
            CreateMap<Product, ProductModel>().ReverseMap(); 
        }

    }
}
