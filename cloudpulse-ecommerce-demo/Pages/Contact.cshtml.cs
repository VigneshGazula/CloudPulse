using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace cloudpulse_ecommerce_demo.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public ContactFormInput ContactForm { get; set; } = new();

    [TempData]
    public string? SuccessMessage { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return new JsonResult(new { success = false, message = "Please fill in all required fields properly." });
            }
            return Page();
        }

        // Server-side logging of submission
        _logger.LogInformation(
            "Contact form submitted by {Name} ({Email}). Subject: {Subject}. Message: {Message}",
            ContactForm.Name,
            ContactForm.Email,
            ContactForm.Subject,
            ContactForm.Message
        );

        if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
        {
            return new JsonResult(new
            {
                success = true,
                message = "Thank you! Your message has been sent successfully. We'll be in touch shortly."
            });
        }

        SuccessMessage = "Thank you! Your message has been sent successfully. We'll be in touch within 24 hours.";
        return RedirectToPage("/Contact");
    }

    public class ContactFormInput
    {
        [Required(ErrorMessage = "Your name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a subject")]
        [StringLength(150)]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide your message")]
        [StringLength(2000)]
        public string Message { get; set; } = string.Empty;
    }
}
