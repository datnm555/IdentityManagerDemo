using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models;

public class LoginViewModel
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DisplayName("Remember me?")]
    public bool RememerMe { get; set; }
}