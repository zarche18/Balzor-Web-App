using ProductWeb.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWeb.API.Infrastructure.Data
{
    public class ProductWebDbContext : DbContext
    {
        private readonly DbContextOptions<ProductWebDbContext> _options;

        public DbContextOptions<ProductWebDbContext> Options
        {
            get
            {
                return _options;
            }
        }

        public ProductWebDbContext(DbContextOptions<ProductWebDbContext> options)
            : base(options)
        {
            _options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Id, Name, price , image , descritpion
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 1,
                Name = "Thanakha Perfect Liquid to Powder Foundation",
                Price = 11500,
                Image = "/Images/TNK-foundation-3.jpg",
                Description = "Introducing the only foundation a girl will ever need for a Matte Golden Complexion!"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 2,
                Name = "Thanakha Powder Pact",
                Price = 8690,
                Image = "/Images/Thanakha Powder Pact.png",
                Description = "Thanakha Loose Mineral Powder weightlessly locks in make-up for perfect long-lasting wear with a flawless, pore-less finish creating a modern, velvety matte look with a touch of sheer coverage, while Natural Thanakha essence absorbs excess oil allowing you to be Selfie Perfect and HD ready all day."
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 3,
                Name = "Thanakha Water Recharging Sleeping Mask - Night Cream - Old",
                Price = 11500,
                Image = "/Images/Thanakha Water Recharging Sleeping Mask - Night Cream - Old.jpg",
                Description = "our skin will look and feel radiant, refreshed, and soft - so you wake up with soft, glowing skin! "
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 4,
                Name = "Perfect Look in a Palette",
                Price = 6550,
                Image = "/Images/Perfect Look in a Palette.jpeg",
                Description = "Makeup palette collaboration with Moguk Pauk Pauk, leading fashion designer and makeup artist."
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 5,
                Name = "Perfume",
                Price = 5950,
                Image = "/Images/Perfume.jpeg",
                Description = "Rejuvenate and refresh your spirit with a spritz of Bella Perfumes. Easy to carry, travel-friendly size."
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 6,
                Name = "Superstar Perfect Matte Foundation",
                Price = 14500,
                Image = "/Images/Superstar Perfect Matte Foundation.png",
                Description = "Foundation fit for a Superstar – specially made for Superstars who need to look perfect all day and night."
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 7,
                Name = "Bella Serum Sheet Maskn",
                Price = 2050,
                Image = "/Images/Bella Serum Sheet Mask.jpeg",
                Description = "Suitable for All Skin Types.Alcohol-Free. Paraben-Free."
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ID = 8,
                Name = "Watermelon Jelly Night Cream",
                Price = 11500,
                Image = "/Images/Watermelon Jelly Night Cream.jpeg",
                Description = "Wake up to juicy skin: nourished, renewed, glowing."
            });
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(10, 2); // Adjust precision and scale as needed
        } 
        public DbSet<Product> products { get; set; }

    }
}
