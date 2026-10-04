using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Models;

namespace cloudpulse_ecommerce_demo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<CartItem> CartItems => Set<CartItem>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(u => u.Username).IsUnique();
            entity.HasIndex(u => u.Email).IsUnique();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Price).HasPrecision(18, 2);
            entity.Property(p => p.Category).IsRequired();
            entity.HasIndex(p => p.Category);
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasIndex(ci => ci.CartId);
            entity.HasIndex(ci => ci.UserId);
            entity.HasOne(ci => ci.Product)
                  .WithMany()
                  .HasForeignKey(ci => ci.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(ci => ci.User)
                  .WithMany(u => u.CartItems)
                  .HasForeignKey(ci => ci.UserId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(o => o.TotalAmount).HasPrecision(18, 2);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.Property(oi => oi.UnitPrice).HasPrecision(18, 2);
            entity.HasOne(oi => oi.Order)
                  .WithMany(o => o.OrderItems)
                  .HasForeignKey(oi => oi.OrderId)
                  .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(oi => oi.Product)
                  .WithMany()
                  .HasForeignKey(oi => oi.ProductId)
                  .OnDelete(DeleteBehavior.Restrict);
        });

        // Seed products table with the 242 products dataset
        SeedProducts(modelBuilder);
    }

    private static void SeedProducts(ModelBuilder modelBuilder)
    {
        var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        string? jsonPath = null;
        var baseDir = AppContext.BaseDirectory;
        var candidatePaths = new[]
        {
            Path.Combine(baseDir, "data", "products.json"),
            Path.Combine(Directory.GetCurrentDirectory(), "data", "products.json"),
            Path.Combine(baseDir, "..", "..", "..", "data", "products.json"),
            Path.Combine(Directory.GetCurrentDirectory(), "cloudpulse-ecommerce-demo", "data", "products.json")
        };

        foreach (var path in candidatePaths)
        {
            if (File.Exists(path))
            {
                jsonPath = Path.GetFullPath(path);
                break;
            }
        }

        if (jsonPath != null && File.Exists(jsonPath))
        {
            var json = System.IO.File.ReadAllText(jsonPath);
            var options = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json, options);
            if (products != null && products.Count > 0)
            {
                foreach (var product in products)
                {
                    product.CreatedAt = seedDate;
                }
                modelBuilder.Entity<Product>().HasData(products);
            }
        }
    }
}
