using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CakeShopBotique.Models;

namespace CakeShopBotique.Data
{
    public class CakeShopBotiqueContext : DbContext
    {
        public CakeShopBotiqueContext (DbContextOptions<CakeShopBotiqueContext> options)
            : base(options)
        {
        }

        public DbSet<CakeShopBotique.Models.Product> Product { get; set; }

        public DbSet<CakeShopBotique.Models.Category> Category { get; set; }

        public DbSet<CakeShopBotique.Models.Image> Image { get; set; }

        public DbSet<CakeShopBotique.Models.Costumer> Costumer { get; set; }

        public DbSet<CakeShopBotique.Models.Purchase> Purchase { get; set; }

        public DbSet<CakeShopBotique.Models.Shipping> Shipping { get; set; }

        public DbSet<CakeShopBotique.Models.ShopBag> ShopBag { get; set; }

        public DbSet<CakeShopBotique.Models.ShopBagProduct> ShopBagProduct { get; set; }

        public DbSet<CakeShopBotique.Models.SildeBanner> SildeBanner { get; set; }
    }
}
