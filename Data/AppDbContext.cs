using Microsoft.EntityFrameworkCore;
using ProductManagementApi.Models;

namespace ProductManagementApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 1200.00m,
                    StockQuantity = 10,
                    CreatedDate = new DateTime(2025, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    Name = "Keyboard",
                    Category = "Electronics",
                    Price = 75.50m,
                    StockQuantity = 50,
                    CreatedDate = new DateTime(2025, 1, 2)
                },
                new Product
                {
                    Id = 3,
                    Name = "Office Chair",
                    Category = "Furniture",
                    Price = 250.00m,
                    StockQuantity = 15,
                    CreatedDate = new DateTime(2025, 1, 3)
                }
            );
        }
    }
}