using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
