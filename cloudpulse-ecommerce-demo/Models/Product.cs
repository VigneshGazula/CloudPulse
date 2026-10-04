using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace cloudpulse_ecommerce_demo.Models;

public class Product
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [Required]
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [Required]
    [JsonPropertyName("image")]
    public string ImageUrl { get; set; } = string.Empty;

    [Required]
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
