using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cloudpulse_ecommerce_demo.Data;
using cloudpulse_ecommerce_demo.Models;
using cloudpulse_ecommerce_demo.Services;

namespace cloudpulse_ecommerce_demo.Pages.Account;

public class RegisterModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly ICartService _cartService;
    private readonly ILogger<RegisterModel> _logger;

    public RegisterModel(
        AppDbContext context, 
        IPasswordHasher<User> passwordHasher, 
        ICartService cartService,
        ILogger<RegisterModel> logger)
    {
        _context = context;
        _passwordHasher = passwordHasher;
        _cartService = cartService;
        _logger = logger;
    }

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? ReturnUrl { get; set; }

    [TempData]
    public string? ErrorMessage { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        [RegularExpression(@"^[a-zA-Z0-9_\-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores, and dashes")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    public IActionResult OnGet(string? returnUrl = null)
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            return LocalRedirect(returnUrl ?? "/");
        }

        ReturnUrl = returnUrl;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        ReturnUrl = returnUrl ?? "/";

        if (!ModelState.IsValid)
        {
            return Page();
        }

        var normalizedUsername = Input.Username.Trim().ToLowerInvariant();
        var normalizedEmail = Input.Email.Trim().ToLowerInvariant();

        // Check if username already exists
        var usernameExists = await _context.Users
            .AnyAsync(u => u.Username.ToLower() == normalizedUsername);

        if (usernameExists)
        {
            ModelState.AddModelError(nameof(Input.Username), "This username is already taken. Please choose another.");
            return Page();
        }

        // Check if email already exists
        var emailExists = await _context.Users
            .AnyAsync(u => u.Email.ToLower() == normalizedEmail);

        if (emailExists)
        {
            ModelState.AddModelError(nameof(Input.Email), "An account with this email already exists. Please sign in instead.");
            return Page();
        }

        // Create new User entity
        var user = new User
        {
            Username = Input.Username.Trim(),
            Email = normalizedEmail,
            CreatedAt = DateTime.UtcNow
        };

        user.PasswordHash = _passwordHasher.HashPassword(user, Input.Password);

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        _logger.LogInformation("New user registered: {Username} ({Email}) with ID {UserId}", user.Username, user.Email, user.Id);

        // Sign in user with cookie authentication
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var authProperties = new AuthenticationProperties
        {
            IsPersistent = true,
            ExpiresUtc = DateTimeOffset.UtcNow.AddDays(14)
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties
        );

        // Seamlessly migrate guest cookie cart items into user's account
        if (Request.Cookies.TryGetValue("CloudPulse_CartId", out var guestCartId) && !string.IsNullOrWhiteSpace(guestCartId))
        {
            await _cartService.MigrateGuestCartToUserAsync(guestCartId, user.Id);
        }

        return LocalRedirect(ReturnUrl);
    }
}
