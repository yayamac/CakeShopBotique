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
    }
}
