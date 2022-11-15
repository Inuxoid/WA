using System.ComponentModel.DataAnnotations;

namespace WA.Models;

public class OrderModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Details { get; set; }
}