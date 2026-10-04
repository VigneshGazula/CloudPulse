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

public class LoginModel : PageModel
{
    private readonly AppDbContext _context;
    private readonly IPasswordHasher<User> _passwordHasher;
    private readonly ICartService _cartService;
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(
        AppDbContext context, 
        IPasswordHasher<User> passwordHasher, 
        ICartService cartService,
        ILogger<LoginModel> logger)
    {
        _context = context;
        _passwordHasher = passwordHasher;
        _cartService = cartService;
        _logger = logger;
    }

    [BindProperty]
    public InputModel Input { get; set; } = new();

    public string? ReturnUrl { get; set; }

    public class InputModel
    {
        [Required(ErrorMessage = "Please enter your username or email address")]
        public string UsernameOrEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; } = true;
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

        var normalizedInput = Input.UsernameOrEmail.Trim().ToLowerInvariant();

        // Search user by Username or Email
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Username.ToLower() == normalizedInput || u.Email.ToLower() == normalizedInput);

        if (user == null)
        {
            ModelState.AddModelError(string.Empty, "Invalid login credentials. Please check your username/email and password.");
            return Page();
        }

        // Verify password hash
        var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, Input.Password);
        if (verificationResult == PasswordVerificationResult.Failed)
        {
            ModelState.AddModelError(string.Empty, "Invalid login credentials. Please check your username/email and password.");
            return Page();
        }

        _logger.LogInformation("User {Username} logged in successfully.", user.Username);

        // Sign in user
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var authProperties = new AuthenticationProperties
        {
            IsPersistent = Input.RememberMe,
            ExpiresUtc = Input.RememberMe ? DateTimeOffset.UtcNow.AddDays(14) : null
        };

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            authProperties
        );

        // Migrate existing guest cart items to the user account
        if (Request.Cookies.TryGetValue("CloudPulse_CartId", out var guestCartId) && !string.IsNullOrWhiteSpace(guestCartId))
        {
            await _cartService.MigrateGuestCartToUserAsync(guestCartId, user.Id);
        }

        return LocalRedirect(ReturnUrl);
    }
}
