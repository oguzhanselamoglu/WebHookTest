using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirLineWeb.Models;

public class FlightDetail
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string FlightCode { get; set; }
    
    [Required]
    public decimal Price { get; set; }
}