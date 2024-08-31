using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{


    namespace OOP.ApplicationContext
    {
        public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,int>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>()
                    .Property(p => p.Price)
                    .HasColumnType("decimal(18,2)");

                base.OnModelCreating(modelBuilder);
            }

            public DbSet<Product> Products { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Category> Categories { get; set; }
        }

    }

}
