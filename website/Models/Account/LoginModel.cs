using System.ComponentModel.DataAnnotations;

namespace website.Models.Account
{
    public class LoginModel
    {
        [Required, EmailAddress]
        public String? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
