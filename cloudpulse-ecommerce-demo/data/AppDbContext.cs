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

        // Seed products table with the exact dataset
        SeedProducts(modelBuilder);
    }

    private static void SeedProducts(ModelBuilder modelBuilder)
    {
        var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "CloudPulse Apex Runner",
                Price = 149.99m,
                ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=800&q=80",
                Description = "Ultra-responsive cushioning with breathable mesh upper. Designed for all-day urban agility and high performance.",
                Category = "Running",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 2,
                Name = "Retro Court Minimalist",
                Price = 129.50m,
                ImageUrl = "https://images.unsplash.com/photo-1549298916-b41d501d3772?auto=format&fit=crop&w=800&q=80",
                Description = "Clean, understated court silhouette crafted from buttery Italian leather with vulcanized gum sole.",
                Category = "Sneakers",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 3,
                Name = "Amber Suede Chelsea Boot",
                Price = 189.00m,
                ImageUrl = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?auto=format&fit=crop&w=800&q=80",
                Description = "Hand-stitched premium water-resistant suede with ergonomic elastic side gussets and Goodyear welt.",
                Category = "Boots",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 4,
                Name = "Veloce Air Stride 02",
                Price = 165.00m,
                ImageUrl = "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?auto=format&fit=crop&w=800&q=80",
                Description = "Engineered knit mesh upper paired with high-rebound nitrogen-infused foam sole for marathon comfort.",
                Category = "Running",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 5,
                Name = "Mono Horizon Low-Top",
                Price = 115.00m,
                ImageUrl = "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?auto=format&fit=crop&w=800&q=80",
                Description = "Timeless skate-inspired low-top with reinforced canvas, contrast stitching, and memory-foam insole.",
                Category = "Casual",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 6,
                Name = "Artisan Leather Penny Loafer",
                Price = 210.00m,
                ImageUrl = "https://images.unsplash.com/photo-1533867617858-e7b97e060509?auto=format&fit=crop&w=800&q=80",
                Description = "Polished calfskin leather with traditional moc-toe stitching and stacked leather heel. Effortlessly elevated.",
                Category = "Loafers",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 7,
                Name = "TrailMaster All-Weather Hiker",
                Price = 195.00m,
                ImageUrl = "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?auto=format&fit=crop&w=800&q=80",
                Description = "Vibram-lugged outsole with waterproof breathable membrane. Built for rugged trails and city winters.",
                Category = "Boots",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 8,
                Name = "Aero Glide Knit Slip-On",
                Price = 98.00m,
                ImageUrl = "https://images.unsplash.com/photo-1560769629-975ec94e6a86?auto=format&fit=crop&w=800&q=80",
                Description = "Weightless slip-on sock sneaker engineered with recycled stretch yarn and shock-absorbing outsole.",
                Category = "Sneakers",
                CreatedAt = seedDate
            },
            new Product
            {
                Id = 9,
                Name = "Oxford Heritage Brogue",
                Price = 225.00m,
                ImageUrl = "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?auto=format&fit=crop&w=800&q=80",
                Description = "Hand-burnished cognac leather with wingtip perforations. Refined formal footwear built to last decades.",
                Category = "Casual",
                CreatedAt = seedDate
            }
        );
    }
}
