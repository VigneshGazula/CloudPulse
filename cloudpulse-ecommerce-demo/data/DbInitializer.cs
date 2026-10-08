using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Models;

namespace cloudpulse_ecommerce_demo.Data;

public static class DbInitializer
{
    /// <summary>
    /// Idempotent startup seed: only seeds if the Products table is empty.
    /// </summary>
    public static async Task InitializeAsync(AppDbContext context, ILogger? logger = null)
    {
        // Only seed if Products is empty
        if (await context.Products.AnyAsync())
        {
            logger?.LogInformation("Database already contains products. Skipping seed.");
            return;
        }

        logger?.LogInformation("Products table is empty. Seeding products...");
        await SeedProductsAsync(context, logger);
    }

    /// <summary>
    /// Synchronous idempotent startup seed: only seeds if the Products table is empty.
    /// </summary>
    public static void Initialize(AppDbContext context, ILogger? logger = null)
    {
        // Only seed if Products is empty
        if (context.Products.Any())
        {
            logger?.LogInformation("Database already contains products. Skipping seed.");
            return;
        }

        logger?.LogInformation("Products table is empty. Seeding products...");
        SeedProducts(context, logger);
    }

    private static string? FindProductsJsonPath()
    {
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
                return Path.GetFullPath(path);
            }
        }

        return null;
    }

    public static async Task SeedProductsAsync(AppDbContext context, ILogger? logger = null)
    {
        var jsonPath = FindProductsJsonPath();
        if (jsonPath == null || !File.Exists(jsonPath))
        {
            logger?.LogWarning("products.json not found for seeding.");
            return;
        }

        var json = await File.ReadAllTextAsync(jsonPath);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var products = JsonSerializer.Deserialize<List<Product>>(json, options);
        if (products != null && products.Count > 0)
        {
            var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            foreach (var product in products)
            {
                if (product.CreatedAt == default)
                {
                    product.CreatedAt = seedDate;
                }
            }

            await context.Products.AddRangeAsync(products);
            await context.SaveChangesAsync();
            logger?.LogInformation("Successfully seeded {Count} products.", products.Count);

            try
            {
                if (context.Database.IsRelational())
                {
                    await context.Database.ExecuteSqlRawAsync(
                        "SELECT setval(pg_get_serial_sequence('\"Products\"', 'Id'), coalesce(max(\"Id\"), 1)) FROM \"Products\";");
                }
            }
            catch
            {
                // Sequence reset ignored if database provider or sequence does not support it
            }
        }
    }

    public static void SeedProducts(AppDbContext context, ILogger? logger = null)
    {
        var jsonPath = FindProductsJsonPath();
        if (jsonPath == null || !File.Exists(jsonPath))
        {
            logger?.LogWarning("products.json not found for seeding.");
            return;
        }

        var json = File.ReadAllText(jsonPath);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var products = JsonSerializer.Deserialize<List<Product>>(json, options);
        if (products != null && products.Count > 0)
        {
            var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            foreach (var product in products)
            {
                if (product.CreatedAt == default)
                {
                    product.CreatedAt = seedDate;
                }
            }

            context.Products.AddRange(products);
            context.SaveChanges();
            logger?.LogInformation("Successfully seeded {Count} products.", products.Count);

            try
            {
                if (context.Database.IsRelational())
                {
                    context.Database.ExecuteSqlRaw(
                        "SELECT setval(pg_get_serial_sequence('\"Products\"', 'Id'), coalesce(max(\"Id\"), 1)) FROM \"Products\";");
                }
            }
            catch
            {
                // Sequence reset ignored if database provider or sequence does not support it
            }
        }
    }
}
