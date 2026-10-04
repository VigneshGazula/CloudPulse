using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Data;
using cloudpulse_ecommerce_demo.Models;
using cloudpulse_ecommerce_demo.Services;

namespace cloudpulse_ecommerce_demo.Pages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly ICartService _cartService;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(AppDbContext context, ICartService cartService, ILogger<IndexModel> logger)
    {
        _context = context;
        _cartService = cartService;
        _logger = logger;
    }

    public List<Product> Products { get; set; } = new();
    public List<string> Categories { get; set; } = new();

    [BindProperty(SupportsGet = true)]
    public string? SelectedCategory { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Category { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? Q { get; set; }

    public int CartItemCount { get; set; }

    [TempData]
    public string? StatusMessage { get; set; }

    public async Task OnGetAsync()
    {
        try
        {
            var effectiveCategory = !string.IsNullOrWhiteSpace(Category) ? Category : SelectedCategory;
            SelectedCategory = effectiveCategory;

            var query = _context.Products.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(SelectedCategory) && !SelectedCategory.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                var catLower = SelectedCategory.Trim().ToLower();
                query = query.Where(p => p.Category != null && p.Category.ToLower() == catLower);
            }

            if (!string.IsNullOrWhiteSpace(Q))
            {
                var term = Q.Trim().ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(term) || (p.Description != null && p.Description.ToLower().Contains(term)));
            }

            Products = await query.OrderBy(p => p.Id).ToListAsync();

            Categories = await _context.Products
                .AsNoTracking()
                .Where(p => p.Category != null)
                .Select(p => p.Category!)
                .Distinct()
                .OrderBy(c => c)
                .ToListAsync();

            CartItemCount = await _cartService.GetCartCountAsync();
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Could not fetch products from database. Loading seeded fallback dataset.");
            LoadFallbackProducts();
        }
    }

    public async Task<IActionResult> OnPostAddToCartAsync(int productId, int quantity = 1)
    {
        try
        {
            await _cartService.AddToCartAsync(productId, quantity);
            var count = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new { success = true, cartCount = count, message = "Item added to cart!" });
            }

            StatusMessage = "Item successfully added to your cart!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to add product {ProductId} to cart.", productId);
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new { success = false, message = "Could not add item to cart." });
            }
        }

        return RedirectToPage(new { SelectedCategory });
    }

    private void LoadFallbackProducts()
    {
        try
        {
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "products.json");
            if (System.IO.File.Exists(jsonPath))
            {
                var json = System.IO.File.ReadAllText(jsonPath);
                var items = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (items != null)
                {
                    Categories = items
                        .Where(p => p.Category != null)
                        .Select(p => p.Category!)
                        .Distinct()
                        .OrderBy(c => c)
                        .ToList();

                    if (!string.IsNullOrWhiteSpace(SelectedCategory) && !SelectedCategory.Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        Products = items.Where(p => p.Category == SelectedCategory).ToList();
                    }
                    else
                    {
                        Products = items;
                    }
                }
            }
        }
        catch
        {
            // Fallback gracefully
        }
    }
}
