using System.ComponentModel.DataAnnotations;

namespace LungDiseaseDiagnosis.Models;

public class User
{
    public int ID { get; set; }
    [Required(ErrorMessage = "Full Name is required")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? Username { get; set; }
    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Role is required")]
    public MedType? Type { get; set; }
}
