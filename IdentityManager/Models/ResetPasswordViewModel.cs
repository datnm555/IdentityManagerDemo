using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models;

public class ResetPasswordViewModel
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DisplayName("Confirm Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match")]
    public string ConfirmPassword { get; set; }

    public string Code { get; set; }
}