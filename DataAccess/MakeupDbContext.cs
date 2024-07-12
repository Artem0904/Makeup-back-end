using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MakeupDbContext : IdentityDbContext<User>
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        public MakeupDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Brand>().HasData(new[]
            {
                new Brand { Id = 1, Name="Chanel"},
                new Brand { Id = 2, Name="Dior"},
            });

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category { Id = 1, Name = "Perfumes" },
            });

            modelBuilder.Entity<Gender>().HasData(new[]
            {
                new Gender { Id = 1, Name = "Female" },
                new Gender { Id = 2, Name = "Male" },
            });

            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product { Id = 1, Name = "Chanel Bleu de Chanel Parfum", BrandId = 1, GenderId = 2, CategoryId = 1, Price = 12592, Discount = 0, Description = "", Image= "data:image/webp;base64,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" },
            });
        }
    }
}
