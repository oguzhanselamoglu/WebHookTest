using System.ComponentModel.DataAnnotations;

namespace AirLineWeb.Models;

public class WebhookSubscription
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string WebHookUrl { get; set; }
    [Required]
    public string Screet { get; set; }
    [Required]
    public string WebHookType { get; set; }
    [Required]
    public string WebhookPublisher { get; set; }
}