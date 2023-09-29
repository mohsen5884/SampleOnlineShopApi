using Microsoft.EntityFrameworkCore;
using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Core
{
    public class OnlineShopDbContex:DbContext
    {
        public OnlineShopDbContex(DbContextOptions options):base(options)
        {
            
        }
        //public DbSet<Product> PRODUCTS { get; set; }
        public DbSet<Product> PRODUCTS =>Set<Product>();
    }
}
