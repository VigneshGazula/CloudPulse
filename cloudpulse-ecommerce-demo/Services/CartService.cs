using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Data;
using cloudpulse_ecommerce_demo.Models;

namespace cloudpulse_ecommerce_demo.Services;

public interface ICartService
{
    string GetOrCreateCartId();
    int? GetCurrentUserId();
    Task<int> GetCartCountAsync();
    Task<List<CartItem>> GetCartItemsAsync();
    Task<CartItem> AddToCartAsync(int productId, int quantity = 1);
    Task UpdateQuantityAsync(int cartItemId, int newQuantity);
    Task RemoveFromCartAsync(int cartItemId);
    Task ClearCartAsync();
    Task<decimal> GetCartTotalAsync();
    Task MigrateGuestCartToUserAsync(string guestCartId, int userId);
}

public class CartService : ICartService
{
    private const string CartCookieKey = "CloudPulse_CartId";
    private readonly AppDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CartService(AppDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public int? GetCurrentUserId()
    {
        var user = _httpContextAccessor.HttpContext?.User;
        if (user?.Identity?.IsAuthenticated == true)
        {
            var idClaim = user.FindFirst(ClaimTypes.NameIdentifier);
            if (idClaim != null && int.TryParse(idClaim.Value, out var id))
            {
                return id;
            }
        }
        return null;
    }

    public string GetOrCreateCartId()
    {
        var httpContext = _httpContextAccessor.HttpContext 
            ?? throw new InvalidOperationException("HttpContext unavailable");

        var userId = GetCurrentUserId();
        if (userId.HasValue)
        {
            return $"user_{userId.Value}";
        }

        if (httpContext.Request.Cookies.TryGetValue(CartCookieKey, out var cartId) && !string.IsNullOrWhiteSpace(cartId))
        {
            return cartId;
        }

        if (httpContext.Items.TryGetValue(CartCookieKey, out var itemCartId) && itemCartId is string s && !string.IsNullOrWhiteSpace(s))
        {
            return s;
        }

        var newCartId = Guid.NewGuid().ToString("N");
        httpContext.Items[CartCookieKey] = newCartId;

        var cookieOptions = new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(30),
            HttpOnly = true,
            IsEssential = true,
            SameSite = SameSiteMode.Lax
        };

        httpContext.Response.Cookies.Append(CartCookieKey, newCartId, cookieOptions);
        return newCartId;
    }

    public async Task<int> GetCartCountAsync()
    {
        try
        {
            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                return await _context.CartItems
                    .Where(c => c.UserId == userId.Value)
                    .SumAsync(c => c.Quantity);
            }

            var cartId = GetOrCreateCartId();
            return await _context.CartItems
                .Where(c => c.CartId == cartId && c.UserId == null)
                .SumAsync(c => c.Quantity);
        }
        catch
        {
            return 0;
        }
    }

    public async Task<List<CartItem>> GetCartItemsAsync()
    {
        try
        {
            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                return await _context.CartItems
                    .Include(c => c.Product)
                    .Where(c => c.UserId == userId.Value)
                    .OrderBy(c => c.Id)
                    .ToListAsync();
            }

            var cartId = GetOrCreateCartId();
            return await _context.CartItems
                .Include(c => c.Product)
                .Where(c => c.CartId == cartId && c.UserId == null)
                .OrderBy(c => c.Id)
                .ToListAsync();
        }
        catch
        {
            return new List<CartItem>();
        }
    }

    public async Task<CartItem> AddToCartAsync(int productId, int quantity = 1)
    {
        var userId = GetCurrentUserId();
        var cartId = GetOrCreateCartId();

        CartItem? cartItem = null;
        if (userId.HasValue)
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.UserId == userId.Value && c.ProductId == productId);
        }
        else
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.CartId == cartId && c.UserId == null && c.ProductId == productId);
        }

        if (cartItem != null)
        {
            cartItem.Quantity += quantity;
        }
        else
        {
            cartItem = new CartItem
            {
                CartId = cartId,
                UserId = userId,
                ProductId = productId,
                Quantity = quantity,
                DateCreated = DateTime.UtcNow
            };
            _context.CartItems.Add(cartItem);
        }

        await _context.SaveChangesAsync();
        return cartItem;
    }

    public async Task UpdateQuantityAsync(int cartItemId, int newQuantity)
    {
        var userId = GetCurrentUserId();
        var cartId = GetOrCreateCartId();

        CartItem? cartItem = null;
        if (userId.HasValue)
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.Id == cartItemId && c.UserId == userId.Value);
        }
        else
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.Id == cartItemId && c.CartId == cartId && c.UserId == null);
        }

        if (cartItem != null)
        {
            if (newQuantity <= 0)
            {
                _context.CartItems.Remove(cartItem);
            }
            else
            {
                cartItem.Quantity = newQuantity;
            }
            await _context.SaveChangesAsync();
        }
    }

    public async Task RemoveFromCartAsync(int cartItemId)
    {
        var userId = GetCurrentUserId();
        var cartId = GetOrCreateCartId();

        CartItem? cartItem = null;
        if (userId.HasValue)
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.Id == cartItemId && c.UserId == userId.Value);
        }
        else
        {
            cartItem = await _context.CartItems
                .FirstOrDefaultAsync(c => c.Id == cartItemId && c.CartId == cartId && c.UserId == null);
        }

        if (cartItem != null)
        {
            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();
        }
    }

    public async Task ClearCartAsync()
    {
        var userId = GetCurrentUserId();
        var cartId = GetOrCreateCartId();

        List<CartItem> items;
        if (userId.HasValue)
        {
            items = await _context.CartItems
                .Where(c => c.UserId == userId.Value)
                .ToListAsync();
        }
        else
        {
            items = await _context.CartItems
                .Where(c => c.CartId == cartId && c.UserId == null)
                .ToListAsync();
        }

        if (items.Any())
        {
            _context.CartItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<decimal> GetCartTotalAsync()
    {
        try
        {
            var userId = GetCurrentUserId();
            if (userId.HasValue)
            {
                return await _context.CartItems
                    .Include(c => c.Product)
                    .Where(c => c.UserId == userId.Value && c.Product != null)
                    .SumAsync(c => c.Quantity * c.Product!.Price);
            }

            var cartId = GetOrCreateCartId();
            return await _context.CartItems
                .Include(c => c.Product)
                .Where(c => c.CartId == cartId && c.UserId == null && c.Product != null)
                .SumAsync(c => c.Quantity * c.Product!.Price);
        }
        catch
        {
            return 0m;
        }
    }

    public async Task MigrateGuestCartToUserAsync(string guestCartId, int userId)
    {
        if (string.IsNullOrWhiteSpace(guestCartId)) return;

        var guestItems = await _context.CartItems
            .Where(c => c.CartId == guestCartId && c.UserId == null)
            .ToListAsync();

        if (!guestItems.Any()) return;

        var userItems = await _context.CartItems
            .Where(c => c.UserId == userId)
            .ToListAsync();

        foreach (var guestItem in guestItems)
        {
            var existingUserItem = userItems.FirstOrDefault(u => u.ProductId == guestItem.ProductId);
            if (existingUserItem != null)
            {
                existingUserItem.Quantity += guestItem.Quantity;
                _context.CartItems.Remove(guestItem);
            }
            else
            {
                guestItem.UserId = userId;
                guestItem.CartId = $"user_{userId}";
            }
        }

        await _context.SaveChangesAsync();
    }
}
