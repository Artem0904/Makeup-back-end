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
                new Product { Id = 1, Name = "Chanel Bleu de Chanel Parfum", BrandId = 1, GenderId = 2, CategoryId = 1, Price = 12592, Discount = 0, Description = "", Image= "" },
            });
        }
    }
}
