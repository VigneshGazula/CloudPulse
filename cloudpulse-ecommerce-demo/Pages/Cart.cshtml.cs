using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Data;
using cloudpulse_ecommerce_demo.Models;
using cloudpulse_ecommerce_demo.Services;

namespace cloudpulse_ecommerce_demo.Pages;

public class CartModel : PageModel
{
    private readonly ICartService _cartService;
    private readonly AppDbContext _context;
    private readonly ILogger<CartModel> _logger;

    public CartModel(ICartService cartService, AppDbContext context, ILogger<CartModel> logger)
    {
        _cartService = cartService;
        _context = context;
        _logger = logger;
    }

    public List<CartItem> CartItems { get; set; } = new();
    public List<Product> Recommendations { get; set; } = new();

    public decimal Subtotal { get; set; }
    public decimal Shipping { get; set; }
    public decimal EstimatedTax { get; set; }
    public decimal Total { get; set; }
    public decimal FreeShippingThreshold { get; } = 50.00m;
    public decimal FreeShippingRemaining => Math.Max(0m, FreeShippingThreshold - Subtotal);
    public int FreeShippingProgressPercent => Subtotal >= FreeShippingThreshold 
        ? 100 
        : (int)Math.Clamp(Math.Round((Subtotal / FreeShippingThreshold) * 100), 0, 100);

    [TempData]
    public string? StatusMessage { get; set; }

    public async Task OnGetAsync()
    {
        await LoadCartDataAsync();
    }

    public async Task<IActionResult> OnPostAddToCartAsync(int productId, int quantity = 1)
    {
        try
        {
            await _cartService.AddToCartAsync(productId, quantity);
            var cartCount = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new { success = true, cartCount, message = "Item added to cart!" });
            }

            StatusMessage = "Item added to cart!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to add product {ProductId} to cart.", productId);
        }

        return RedirectToPage("/Cart");
    }

    public async Task<IActionResult> OnPostUpdateQuantityAsync(int cartItemId, int quantity)
    {
        try
        {
            await _cartService.UpdateQuantityAsync(cartItemId, quantity);
            var cartCount = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                await LoadCartDataAsync();
                return new JsonResult(new
                {
                    success = true,
                    cartCount,
                    subtotal = Subtotal.ToString("F2"),
                    shipping = Shipping == 0 ? "FREE" : $"${Shipping:F2}",
                    tax = EstimatedTax.ToString("F2"),
                    total = Total.ToString("F2"),
                    freeShippingRemaining = FreeShippingRemaining.ToString("F2"),
                    freeShippingProgress = FreeShippingProgressPercent
                });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to update quantity for cart item {CartItemId}.", cartItemId);
        }

        return RedirectToPage("/Cart");
    }

    public async Task<IActionResult> OnPostRemoveAsync(int cartItemId)
    {
        try
        {
            await _cartService.RemoveFromCartAsync(cartItemId);
            var cartCount = await _cartService.GetCartCountAsync();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                await LoadCartDataAsync();
                return new JsonResult(new
                {
                    success = true,
                    cartCount,
                    cartEmpty = !CartItems.Any(),
                    subtotal = Subtotal.ToString("F2"),
                    shipping = Shipping == 0 ? "FREE" : $"${Shipping:F2}",
                    tax = EstimatedTax.ToString("F2"),
                    total = Total.ToString("F2")
                });
            }

            StatusMessage = "Item removed from cart.";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to remove cart item {CartItemId}.", cartItemId);
        }

        return RedirectToPage("/Cart");
    }

    public async Task<IActionResult> OnPostClearAsync()
    {
        try
        {
            await _cartService.ClearCartAsync();
            StatusMessage = "Cart has been cleared.";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to clear cart.");
        }

        return RedirectToPage("/Cart");
    }

    private async Task LoadCartDataAsync()
    {
        CartItems = await _cartService.GetCartItemsAsync();

        Subtotal = CartItems.Sum(ci => ci.Quantity * (ci.Product?.Price ?? 0m));

        if (CartItems.Any())
        {
            // Free shipping over $50, else $9.99
            Shipping = Subtotal >= FreeShippingThreshold ? 0.00m : 9.99m;
            // 8% tax
            EstimatedTax = Math.Round(Subtotal * 0.08m, 2);
            Total = Subtotal + Shipping + EstimatedTax;
        }
        else
        {
            Shipping = 0m;
            EstimatedTax = 0m;
            Total = 0m;
        }

        // Recommendations (4 items not already in cart)
        var cartProductIds = CartItems.Select(ci => ci.ProductId).ToHashSet();
        try
        {
            Recommendations = await _context.Products
                .AsNoTracking()
                .Where(p => !cartProductIds.Contains(p.Id))
                .OrderBy(p => p.Id)
                .Take(4)
                .ToListAsync();
        }
        catch
        {
            Recommendations = await GetFallbackRecommendationsAsync(cartProductIds);
        }
    }

    private async Task<List<Product>> GetFallbackRecommendationsAsync(HashSet<int> excludedIds)
    {
        var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "products.json");
        if (!System.IO.File.Exists(jsonPath)) return new();

        var json = await System.IO.File.ReadAllTextAsync(jsonPath);
        var items = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(json, new System.Text.Json.JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return items?.Where(p => !excludedIds.Contains(p.Id)).Take(4).ToList() ?? new();
    }
}
