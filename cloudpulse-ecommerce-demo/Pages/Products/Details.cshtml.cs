using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Data;
using cloudpulse_ecommerce_demo.Models;
using cloudpulse_ecommerce_demo.Services;

namespace cloudpulse_ecommerce_demo.Pages.Products;

public class DetailsModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ICartService _cartService;
    private readonly ILogger<DetailsModel> _logger;

    public DetailsModel(AppDbContext context, ICartService cartService, ILogger<DetailsModel> logger)
    {
        _context = context;
        _cartService = cartService;
        _logger = logger;
    }

    public Product? Product { get; set; }
    public List<Product> RelatedProducts { get; set; } = new();

    [TempData]
    public string? StatusMessage { get; set; }

    public async Task<IActionResult> OnGetAsync(int id)
    {
        try
        {
            Product = await _context.Products
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to fetch product from database, falling back to local dataset.");
            Product = await GetFallbackProductAsync(id);
        }

        // If product is not found, set 404 status code and let the view render ProductNotFound UI
        if (Product == null)
        {
            Response.StatusCode = 404;
            return Page();
        }

        // Load 4 related products from the same category
        try
        {
            RelatedProducts = await _context.Products
                .AsNoTracking()
                .Where(p => p.Id != id && p.Category == Product.Category)
                .OrderBy(p => p.Id)
                .Take(4)
                .ToListAsync();
        }
        catch
        {
            RelatedProducts = await GetFallbackRelatedProductsAsync(id, Product.Category);
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAddToCartAsync(int id, int quantity = 1)
    {
        if (quantity < 1) quantity = 1;

        try
        {
            await _cartService.AddToCartAsync(id, quantity);
            var cartCount = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new
                {
                    success = true,
                    cartCount,
                    message = $"{quantity} item(s) added to cart!"
                });
            }

            StatusMessage = "Item successfully added to cart!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to add product {ProductId} to cart.", id);
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new { success = false, message = "Could not add to cart." });
            }
        }

        return RedirectToPage("/Products/Details", new { id });
    }

    public async Task<IActionResult> OnPostBuyNowAsync(int id, int quantity = 1)
    {
        if (quantity < 1) quantity = 1;

        try
        {
            await _cartService.AddToCartAsync(id, quantity);
            var cartCount = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new
                {
                    success = true,
                    cartCount,
                    redirectUrl = "/#cart"
                });
            }

            return RedirectToPage("/Index", null, "cart");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Buy Now failed for product {ProductId}.", id);
            return RedirectToPage("/Products/Details", new { id });
        }
    }

    private async Task<Product?> GetFallbackProductAsync(int id)
    {
        var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "products.json");
        if (!System.IO.File.Exists(jsonPath)) return null;

        var json = await System.IO.File.ReadAllTextAsync(jsonPath);
        var items = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json, new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return items?.FirstOrDefault(p => p.Id == id);
    }

    private async Task<List<Product>> GetFallbackRelatedProductsAsync(int id, string? category)
    {
        var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "products.json");
        if (!System.IO.File.Exists(jsonPath)) return new();

        var json = await System.IO.File.ReadAllTextAsync(jsonPath);
        var items = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json, new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return items?.Where(p => p.Id != id && p.Category == category)
                     .OrderBy(p => p.Id)
                     .Take(4)
                     .ToList() ?? new();
    }
}
