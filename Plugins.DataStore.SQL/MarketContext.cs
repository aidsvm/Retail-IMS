
using CoreBusiness;
using Microsoft.EntityFrameworkCore;


namespace Plugins.DataStore.SQL;

public class MarketContext : DbContext
{
    public MarketContext(DbContextOptions<MarketContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId);

        // seeding data
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Produce", Description = "Produce Department" },
            new Category { CategoryId = 2, Name = "Meat", Description = "Meat Department" },
            new Category { CategoryId = 3, Name = "Seafood", Description = "Seafood Department" },
            new Category { CategoryId = 4, Name = "Deli", Description = "Deli Department" },
            new Category { CategoryId = 5, Name = "Bakery", Description = "Bakery Department" }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
            new Product { ProductId = 2, CategoryId = 5, Name = "Wheat Bread", Quantity = 250, Price = 6.99 },
            new Product { ProductId = 3, CategoryId = 1, Name = "Lemonade", Quantity = 100, Price = 4.99 },
            new Product { ProductId = 4, CategoryId = 4, Name = "Ham and Cheese Sub", Quantity = 50, Price = 7.99 },
            new Product { ProductId = 5, CategoryId = 2, Name = "Sirlon", Quantity = 125, Price = 8.99 },
            new Product { ProductId = 6, CategoryId = 1, Name = "Apple", Quantity = 300, Price = 0.99 }
            );

    }
}

