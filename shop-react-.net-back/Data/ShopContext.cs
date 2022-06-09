using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shop_react_.net_back.Entities;

namespace shop_react_.net_back.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<product> products { get; set; }

        // public DbSet<User> Users { get; set; }
        // public DbSet<Role> Roles { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole{Name = "Customer", NormalizedName = "CUSTOMER"},
                    new IdentityRole{Name = "Admin", NormalizedName = "ADMIN"}
                );
        }
    }
}
