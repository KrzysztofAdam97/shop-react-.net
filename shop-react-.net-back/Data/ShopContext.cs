using System;
using Microsoft.EntityFrameworkCore;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
